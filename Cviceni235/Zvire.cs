using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CviceniDedicnost
{
    public abstract class Zvire
    {
        public int Vek { get; private set; }

        public string Druh { get; private set; }

        public Zvire(int vek, string druh)
        {
            Vek = vek;
            Druh = druh;
        }

        public abstract void VydavejZvuk();
    }
}
