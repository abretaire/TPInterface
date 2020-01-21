using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPInterface
{
    public class CalculateurBeneficeAleatoire : ICalculateurDeBenefice
    {
        public decimal Taux { get; set; }

        public CalculateurBeneficeAleatoire()
        {
            Random rd = new Random();
            Taux = (decimal)rd.NextDouble() / 10;
        }
   

        public decimal CalculBenefice(decimal solde)
        {
            return solde * (1 + Taux);
        }


    }



  
}