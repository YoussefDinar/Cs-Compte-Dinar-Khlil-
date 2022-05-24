using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHLIL_MUSTAPHA___DINAR_YOUSSEF
{
     class ComptePayant : Compte
    {
        private double Taux;

        
        public ComptePayant(Client Prop, Devise Solde) : base(Prop, Solde)
        {
           
                this.Taux = 5.00;
         
        }

        public override void print()
        {
           
            base.print();
            Console.Write(" Taux Interet : " + this.Taux);
        }

        public override bool RetirerArgent(Devise Montant)
        {
            Devise d = (Montant * (Taux / 100));

            
            return base.RetirerArgent((Montant + d)*10);
        }

       

         public override void DeposerArgent(Devise mt)
        {

            Devise d = (mt * (Taux / 100));
            

             base.DeposerArgent((mt +d)*9.5);
        }



    }
}
