using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NepovinnyUkolOOP
{
    internal class Obdelnik
    {
        private double sirka;
        private double vyska;

        public double Sirka
        {
            get { return sirka; }
            private set
            {
                if (value == 0)
                {
                    Console.WriteLine("Sirka nesmi byt nula. Hodnota byla nastavena na 1.");
                    sirka = 1;
                }
                else
                {
                    sirka = value;
                }
            }
        }

        // varianta s init, nelze kvůli metodě Zvetsi :
        //        public double Sirka
        //    {
        //            get => sirka;
        //            init
        //    {
        //                if (value == 0)
        //                {
        //                    Console.WriteLine("Sirka nesmi byt nula. Hodnota byla nastavena na 1.");
        //                    sirka = 1;
        //                }
        //                else
        //                {
        //                    sirka = value;
        //                }
        //            }
        //        }

        public double Vyska
        {
            get { return vyska; }
            private set
            {
                if (value == 0)
                {
                    Console.WriteLine("Vyska nesmi byt nula. Hodnota byla nastavena na 1.");
                    vyska = 1;
                }
                else
                {
                    vyska = value;
                }
            }
        }

        public double Obsah => Sirka * Vyska;
        public double Obvod => 2 * (Sirka + Vyska); 
        

        public Obdelnik(double sirka, double vyska)
        {
            Sirka = sirka;
            Vyska = vyska;
        }

        public Obdelnik(double strana) : this(strana, strana)
        {

        }

        public void Zvetsi(double sirka, double vyska)
        {
            Sirka += sirka;
            Vyska += vyska;
        }

        public void Vypis()
        {
            Console.WriteLine($"Sirka: {Sirka}, Vyska: {Vyska}, Obsah: {Obsah} a Obvod: {Obvod}");
        }
    }
}

