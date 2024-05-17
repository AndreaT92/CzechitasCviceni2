﻿using System;
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
                    Console.WriteLine("Sirka nesmí být nula. Hodnota byla nastavena na 1.");
                    sirka = 1;
                }
                else
                {
                    sirka = value;
                }
            }
        }

        public double Vyska
        {
            get { return vyska; }
            private set
            {
                if (value == 0)
                {
                    Console.WriteLine("Vyska nesmí být nula. Hodnota byla nastavena na 1.");
                    vyska = 1;
                }
                else
                {
                    vyska = value;
                }
            }
        }

        public double Obsah
        {
            get
            {
                return Sirka * Vyska;
            }
        }
        public double Obvod
        {
            get
            {
                return 2 * (Sirka + Vyska);
            }
        }

        public Obdelnik(double sirka, double vyska)
        {
            Sirka = sirka;
            Vyska = vyska;
        }

        public Obdelnik(double strana) : this(strana, strana)
        {

        }

        public void Vypis()
        {
            Console.WriteLine($"Sirka: {Sirka}, Vyska: {Vyska}, Obsah: {Obsah}, Obvod: {Obvod}");
        }
        public void Zvetsi(double zvysitSirka, double zvysitVyska)
        {
            Sirka += zvysitSirka;
            Vyska += zvysitVyska;
        }


    }
    }

