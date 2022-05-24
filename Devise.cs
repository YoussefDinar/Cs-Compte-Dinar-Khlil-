using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHLIL_MUSTAPHA___DINAR_YOUSSEF
{
    class Devise
    {
        private double Valeur;

        public Devise()
        {
            this.Valeur = 0.0;
        }

        public Devise(double Valeur)
        {
            this.Valeur = Valeur;
        }

        public void Aficher()
        {
            Console.Write(" Valeur Devise: " + this.Valeur);
        }

        public static Devise operator +(Devise d1, Devise d2)
        {
            Devise res = new Devise();
            res.Valeur = d1.Valeur += d2.Valeur;
            return res;
        }

        public static Devise operator -(Devise d1, Devise d2)
        {
            Devise res = new Devise();
            res.Valeur = d1.Valeur -= d2.Valeur;
            return res;
        }


        public static bool operator <(Devise d1, Devise d2)
        {
            return d1.Valeur <= d2.Valeur;
        }

        public static bool operator >(Devise d1, Devise d2)
        {
            return d1.Valeur >= d2.Valeur;
        }

        public static Devise operator /(Devise d1, double d2)
        {
            Devise d = new Devise(d1.Valeur / d2);
            return d;
        }

        public static Devise operator *(Devise d1, Devise d2)
        {
            d1.Valeur = (d1.Valeur * d2.Valeur);
            return d1;
        }


        public static Devise operator *(Devise d1, double d2)
        {
            d1.Valeur = (d1.Valeur * d2);
            return d1;
        }
    }
}