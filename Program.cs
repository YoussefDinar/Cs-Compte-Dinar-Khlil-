using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHLIL_MUSTAPHA___DINAR_YOUSSEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BANQUE");
            Client p2 = new Client("p1", "p1","add");
            Devise devise = new Devise(100);
            Devise d1 = new Devise();
           // Devise d2 = new Devise(20.00);
           // Devise d3 = new Devise(10.00);

/*
            ComptePayant c4=new ComptePayant(p2, devise);
            c4.DeposerArgent(d1);
            //c4.RetirerArgent(d1);
            //c4.DeposerArgent(d3);
            c4.print();*/

            CompteCourant c5 = new CompteCourant(p2, devise,d1);
            c5.RetirerArgent(d1);
            //c4.RetirerArgent(d1);
            //c4.DeposerArgent(d3);
            c5.print();


        }
    }
}




