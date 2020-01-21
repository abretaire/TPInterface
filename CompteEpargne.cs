using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPInterface
{
    public class CompteEpargne : Compte
    {
        public decimal TauxAbondement { get; set; } //On ajoute le TauxAbondement


        public CompteEpargne(string proprietaire, decimal tauxAbondement,
            ICalculateurDeBenefice calculateurDeBenefice)
            : base(proprietaire, calculateurDeBenefice)
        {
            TauxAbondement = tauxAbondement;
        }

        public override void AfficherResume()
        {
            Console.WriteLine(string.Format("Résumé du compte de {0}", Proprietaire));
            Console.WriteLine("*************************************");
            Console.WriteLine("Taux d'abondement :  {0}", TauxAbondement);
            Console.WriteLine(string.Format("Solde : {0}", Solde.ToString("N2")));
            Console.WriteLine("Opérations :");
            AfficheOperations();
            Console.WriteLine("*************************************");

        }
    }
}
