using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPInterface
{
    public class CalculateurBeneficeATauxFixe : ICalculateurDeBenefice
    {

        public decimal Taux { get; set; }

        public CalculateurBeneficeATauxFixe(decimal taux)
        {
            Taux = taux;
        }

        public decimal CalculBenefice(decimal solde)
        {
            return solde * (1 + Taux);
        }
    }
}