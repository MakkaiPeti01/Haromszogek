﻿using System;
using System.Collections.Generic;

namespace Haromszogek
{
    internal class Haromszog
    {
        private double aOldal;
        private double bOldal;
        private double cOldal;
        public double Terulet { get; private set; }
        public double Kerulet { get; private set; }
        public bool Szerkesztheto { get; private set; }
        public List<string> AdatokSzoveg()
        {
            List<string> adatok = new List<string>();
            adatok.Add($"a: {aOldal} - b: {bOldal} - c: {cOldal}");
            if (Szerkesztheto)
            {
               adatok.Add($"Kerület: {Kerulet} - Terület: {Terulet}");
            }
            else
            {
                adatok.Add("Nem szerkeszthető");
            }
            return adatok;
        }
        private void Szerk()
        {
            if (aOldal + bOldal > cOldal && aOldal + cOldal > bOldal && bOldal + cOldal > aOldal)
            {
                Szerkesztheto = true;
                Terulet = TeruletSzamitas();
                Kerulet = KeruletSzamitas();
            }
            else
            {
                Szerkesztheto = false;
                Terulet = 0;
                Kerulet = 0;
            }
            
        }
        private double TeruletSzamitas()
        {
            double s = (aOldal + bOldal + cOldal) / 2;
            double ter = Math.Sqrt(s*(s-aOldal)*(s-bOldal)*(s-cOldal));
            return ter;
        }
        private double KeruletSzamitas()
        {
            double ker = aOldal + bOldal + cOldal;
            return ker;
        }
        public Haromszog(double aOldal, double bOldal, double cOldal)
        {
            this.aOldal = aOldal;
            this.bOldal = bOldal;
            this.cOldal = cOldal;
            Szerk();
        }
        public Haromszog(string sor)
        {
            string[] adatok = sor.Split(';');
            aOldal = Convert.ToDouble(adatok[0]);
            bOldal = Convert.ToDouble(adatok[1]);
            cOldal = Convert.ToDouble(adatok[2]);
            Szerk();
        }
    }
}