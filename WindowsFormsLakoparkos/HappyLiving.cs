using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLakoparkos
{
    class HappyLiving
    {
        List<Lakopark> lakoparkok = new List<Lakopark>();

        public HappyLiving(List<Lakopark> lakoparkok)
        {
            this.Lakoparkok = lakoparkok;
        }

        internal List<Lakopark> Lakoparkok { get => lakoparkok; set => lakoparkok = value; }
    }
}
