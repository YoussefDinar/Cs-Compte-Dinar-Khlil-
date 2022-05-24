using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHLIL_MUSTAPHA___DINAR_YOUSSEF
{
     class CompteCourant : Compte
    {
        private Devise decouvert;

        public CompteCourant(Client Prop, Devise Solde , Devise dec) : base(Prop, Solde)
        {

            this.decouvert=dec;

        }
        public override bool RetirerArgent(Devise Montant)
        {
            if (base.checkSolde(this.decouvert))
                return base.RetirerArgent(Montant);

            return false;
        }

    }
}
