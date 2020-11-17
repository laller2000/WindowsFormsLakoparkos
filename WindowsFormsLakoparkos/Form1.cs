using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsLakoparkos
{
    public partial class Form1 : Form
    {
        List<Lakopark> HappyLiving = new List<Lakopark>();
        int aktPark = 0;
        int kepmeret = 45;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string forras = "lakoparkok.txt";
            try
            {
                using (StreamReader sr=new StreamReader(forras))
                {
                    while (!sr.EndOfStream)
                    {
                        string nev = sr.ReadLine();
                        string[] sor = sr.ReadLine().Split(';');
                        int utcak = int.Parse(sor[0]);
                        int hazakSzama = int.Parse(sor[1]);
                        int[,] hazak = new int[utcak, hazakSzama];
                        string haz;
                        while (!string.IsNullOrWhiteSpace(haz =sr.ReadLine()))
                        {
                            string[] h = haz.Split(';');
                            hazak[int.Parse(h[0])-1, int.Parse(h[1])-1] = int.Parse(h[2]);
                        }
                        //--Beolvasva egy lakótelep összes adata ----------------------------------
                        HappyLiving.Add(new Lakopark(nev, utcak, hazakSzama, hazak));

                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Belvasás sikertelen!");
            }
            Update();
           
            }
        private void Update()
        {
            panel1_Hazak.Controls.Clear();
            this.Text = HappyLiving[aktPark].Nev + "lakópark";
            pictureBox1_Nevado.Image = Image.FromFile(HappyLiving[aktPark].Nev+".jpg");
            for (int i = 0; i < HappyLiving[aktPark].UtcakSzama; i++)
            {
                for (int j = 0; j < HappyLiving[aktPark].MaxHazSzam; j++)
                {
                    PictureBox p = new PictureBox();
                    //--A kép méretének és pozíciójának a megadása---
                    p.SetBounds(j * kepmeret, i * kepmeret, kepmeret, kepmeret);
                    switch (HappyLiving[aktPark].Hazak[i, j])
                    {
                        case 3:
                            p.Image = Image.FromFile("Haz3.jpg");
                            break;
                        case 2:
                            p.Image = Image.FromFile("Haz2.jpg");
                            break;
                        case 1:
                            p.Image = Image.FromFile("Haz1.jpg");
                            break;
                        default:
                            p.Image = Image.FromFile("kereszt.jpg");
                            break;
                    }
                    p.SizeMode = PictureBoxSizeMode.Zoom;
                    int utca = i;
                    int haz = j;
                    p.Click += (obj, ev) =>
                    {
                        HappyLiving[aktPark].Hazak[utca, haz]++;
                        if (HappyLiving[aktPark].Hazak[utca, haz]>3)
                        {
                            HappyLiving[aktPark].Hazak[utca, haz] = 0;
                        }
                        Update();
                    };
                    panel1_Hazak.Controls.Add(p);

                }
            }

        }

        private void button1_Jobbra_Click(object sender, EventArgs e)
        {
            if (aktPark < HappyLiving.Count - 1)
            {
                aktPark++;
                if (aktPark == HappyLiving.Count - 1)
                {
                    button1_Jobbra.Hide();
                }
                else
                {
                    button1_Jobbra.Show();
                }
                button1_Balra.Show();
            }
            else 
            {
                
            }
            Update();
        }

        private void button1_Balra_Click(object sender, EventArgs e)
        {
            if (aktPark > 0)
            {
                aktPark--;
                if (aktPark == 0)
                {
                    button1_Balra.Hide();
                }
                else
                {
                    button1_Balra.Show();
                    
                }
                button1_Jobbra.Show();
            }
            Update();
        }

        private void button1_Mentes_Click(object sender, EventArgs e)
        {
            try
            {
                string ujFajl = "lakopark_" + DateTime.Now.ToString("yyyyMMdd_HHmm")+".txt";
                File.Copy("lakoparkok.txt",ujFajl);
                MessageBox.Show("A mentés sikeres!");
                using (StreamWriter sw=new StreamWriter("lakoparkok.txt"))
                {
                    foreach (Lakopark item in HappyLiving)
                    {
                        sw.WriteLine(item.Nev);
                        sw.WriteLine(item.UtcakSzama+";"+item.MaxHazSzam);
                        for (int i = 0; i < item.UtcakSzama; i++)
                        {
                            for (int j = 0; j < item.MaxHazSzam; j++)
                            {
                                if (item.Hazak[i,j]>0)
                                {
                                    sw.WriteLine((i+1)+";"+(j+1)+";"+ item.Hazak[i, j]);
                                }
                            }
                        }
                    }
                    sw.WriteLine();
                }
               
            }
            catch (IOException ex)
            {
                MessageBox.Show("A mentés sikertelen!\n\n"+ex.Message);
                throw;
            }
        }

        private void button1_Statisztika_Click(object sender, EventArgs e)
        {
            bool van = true;
            foreach (Lakopark item in HappyLiving)
            {
                for (int i = 0; i < item.UtcakSzama; i++)
                {
                    van = true;
                    for (int j = 0; j < item.MaxHazSzam; j++)
                    {
                        if (item.Hazak[i,j]==0)
                        {
                            van = false;
                            break;
                        }
                    }
                    if (van)
                    {
                        MessageBox.Show(item.Nev+"lakopark"+(i+1)+". utcája teljesen beépített!");
                    }
                }
               
            }
            

        }

        private void button1_beepitettseg_Click(object sender, EventArgs e)
        {
            double legjobb = 0;
            string legjobbNev = "";
            foreach (Lakopark item in HappyLiving)
            {
                if (item.beepitettseg()>legjobb)
                {
                    legjobb = item.beepitettseg();
                    legjobbNev = item.Nev;
                }
            }
            MessageBox.Show("legjobb beépített:" + legjobbNev + "\n\nBeépítettsége:"+(legjobb*100).ToString("0.00"));
        }
    }
}
