
namespace WindowsFormsLakoparkos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1_Hazak = new System.Windows.Forms.Panel();
            this.button1_Jobbra = new System.Windows.Forms.Button();
            this.pictureBox1_Nevado = new System.Windows.Forms.PictureBox();
            this.button1_Balra = new System.Windows.Forms.Button();
            this.button1_Mentes = new System.Windows.Forms.Button();
            this.button1_Statisztika = new System.Windows.Forms.Button();
            this.button1_beepitettseg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_Nevado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1_Hazak
            // 
            this.panel1_Hazak.Location = new System.Drawing.Point(181, 12);
            this.panel1_Hazak.Name = "panel1_Hazak";
            this.panel1_Hazak.Size = new System.Drawing.Size(607, 327);
            this.panel1_Hazak.TabIndex = 1;
            // 
            // button1_Jobbra
            // 
            this.button1_Jobbra.BackgroundImage = global::WindowsFormsLakoparkos.Properties.Resources.balnyil;
            this.button1_Jobbra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1_Jobbra.Location = new System.Drawing.Point(292, 359);
            this.button1_Jobbra.Name = "button1_Jobbra";
            this.button1_Jobbra.Size = new System.Drawing.Size(122, 55);
            this.button1_Jobbra.TabIndex = 2;
            this.button1_Jobbra.UseVisualStyleBackColor = true;
            this.button1_Jobbra.Click += new System.EventHandler(this.button1_Jobbra_Click);
            // 
            // pictureBox1_Nevado
            // 
            this.pictureBox1_Nevado.Enabled = false;
            this.pictureBox1_Nevado.Image = global::WindowsFormsLakoparkos.Properties.Resources.Puskás_Ferenc;
            this.pictureBox1_Nevado.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1_Nevado.Name = "pictureBox1_Nevado";
            this.pictureBox1_Nevado.Size = new System.Drawing.Size(150, 173);
            this.pictureBox1_Nevado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1_Nevado.TabIndex = 0;
            this.pictureBox1_Nevado.TabStop = false;
            // 
            // button1_Balra
            // 
            this.button1_Balra.BackgroundImage = global::WindowsFormsLakoparkos.Properties.Resources.jobbnyil;
            this.button1_Balra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1_Balra.Location = new System.Drawing.Point(487, 359);
            this.button1_Balra.Name = "button1_Balra";
            this.button1_Balra.Size = new System.Drawing.Size(122, 55);
            this.button1_Balra.TabIndex = 2;
            this.button1_Balra.UseVisualStyleBackColor = true;
            this.button1_Balra.Click += new System.EventHandler(this.button1_Balra_Click);
            // 
            // button1_Mentes
            // 
            this.button1_Mentes.Location = new System.Drawing.Point(42, 203);
            this.button1_Mentes.Name = "button1_Mentes";
            this.button1_Mentes.Size = new System.Drawing.Size(75, 23);
            this.button1_Mentes.TabIndex = 3;
            this.button1_Mentes.Text = "Mentés";
            this.button1_Mentes.UseVisualStyleBackColor = true;
            this.button1_Mentes.Click += new System.EventHandler(this.button1_Mentes_Click);
            // 
            // button1_Statisztika
            // 
            this.button1_Statisztika.Location = new System.Drawing.Point(42, 254);
            this.button1_Statisztika.Name = "button1_Statisztika";
            this.button1_Statisztika.Size = new System.Drawing.Size(75, 23);
            this.button1_Statisztika.TabIndex = 4;
            this.button1_Statisztika.Text = "Statisztika";
            this.button1_Statisztika.UseVisualStyleBackColor = true;
            this.button1_Statisztika.Click += new System.EventHandler(this.button1_Statisztika_Click);
            // 
            // button1_beepitettseg
            // 
            this.button1_beepitettseg.Location = new System.Drawing.Point(51, 293);
            this.button1_beepitettseg.Name = "button1_beepitettseg";
            this.button1_beepitettseg.Size = new System.Drawing.Size(75, 23);
            this.button1_beepitettseg.TabIndex = 5;
            this.button1_beepitettseg.Text = "beepitettseg";
            this.button1_beepitettseg.UseVisualStyleBackColor = true;
            this.button1_beepitettseg.Click += new System.EventHandler(this.button1_beepitettseg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1_beepitettseg);
            this.Controls.Add(this.button1_Statisztika);
            this.Controls.Add(this.button1_Mentes);
            this.Controls.Add(this.button1_Balra);
            this.Controls.Add(this.button1_Jobbra);
            this.Controls.Add(this.panel1_Hazak);
            this.Controls.Add(this.pictureBox1_Nevado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_Nevado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1_Nevado;
        private System.Windows.Forms.Panel panel1_Hazak;
        private System.Windows.Forms.Button button1_Jobbra;
        private System.Windows.Forms.Button button1_Balra;
        private System.Windows.Forms.Button button1_Mentes;
        private System.Windows.Forms.Button button1_Statisztika;
        private System.Windows.Forms.Button button1_beepitettseg;
    }
}

