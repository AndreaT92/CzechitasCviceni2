using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CviceniDedicnost
{
    public class Zirafa : Zvire
    {
        public int PocetNohou { get; private set; }

        public Zirafa(int vek, string druh, int pocetNohou) : base(vek, druh)
        {
            PocetNohou = pocetNohou;
        }

        public override void VydavejZvuk()
        {
            Console.WriteLine("zif zif");
        }
    }
}
