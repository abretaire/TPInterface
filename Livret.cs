using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPInterface
{
    public class Livret : Compte
    {
        
        public Livret(string proprietaire, ICalculateurDeBenefice calculateurDeBenefice)
            : base(proprietaire, calculateurDeBenefice)
        {
        }

        public override void AfficherResume()
        {
            Console.WriteLine(string.Format("Résumé du compte de {0}", Proprietaire));
            Console.WriteLine("*************************************");
            Console.WriteLine(string.Format("Solde : {0}", Solde.ToString("N2")));
            Console.WriteLine("Opérations :");
            AfficheOperations();
            Console.WriteLine("*************************************");
        }
    }
}
