using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakoutRoom165
{
    public class obdelnik
    {
        public double Sirka;
        public double Vyska;

        public obdelnik(double sirka, double vyska)
        {
            Sirka = sirka;
            Vyska = vyska;
        }

        public obdelnik(double strana): this (strana, strana)
        {
            
        }

        public void Vypis()
        {
            Console.WriteLine($" Sirka: {Sirka}, Vyska: {Vyska}");
        }
    }
}
