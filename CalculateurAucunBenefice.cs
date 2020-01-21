using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPInterface
{
    public class CalculateurAucunBenefice : ICalculateurDeBenefice
    {
        public decimal CalculBenefice(decimal solde)
        {
            return solde;
        }
    }
}
