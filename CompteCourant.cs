using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPInterface
{
    public class CompteCourant : Compte //Enfant de la méthode Compte, on récupère tout ce qu'il y a dedant, la liste, le solde ... 
    {
        public decimal DecouvertAutorise { get; set; } //On ajoute cet attribut de découvert autorisé.

        public CompteCourant(string proprietaire, decimal decouvertAutorise,
            ICalculateurDeBenefice calculateurDeBenefice)
            : base(proprietaire, calculateurDeBenefice)
        {
            DecouvertAutorise = decouvertAutorise;
        }
        public override void AfficherResume()
        {
            Console.WriteLine(string.Format("Résumé du compte de {0}", Proprietaire));
            Console.WriteLine("*************************************");
            Console.WriteLine("Decouvert autorisé :  {0}", DecouvertAutorise);
            Console.WriteLine(string.Format("Solde : {0}", Solde.ToString("N2")));
            Console.WriteLine("Opérations :");
            AfficheOperations();
            Console.WriteLine("*************************************");

        }
    }
}
