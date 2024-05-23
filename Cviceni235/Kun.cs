using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CviceniDedicnost
{
    public class Kun : Zvire
    {
        public int RychlostBehu { get; private set; }

        public Kun(int vek, string druh, int rychlostBehu) : base(vek, druh)
        {
        }

        public override void VydavejZvuk()
        {
            Console.WriteLine("ihaaa");
        }
    }
}
