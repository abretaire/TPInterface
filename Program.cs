using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateurBeneficeATauxFixe cbftf = new CalculateurBeneficeATauxFixe(0.05m);
            CalculateurBeneficeAleatoire cba = new CalculateurBeneficeAleatoire();
            CalculateurAucunBenefice cab = new CalculateurAucunBenefice();

            // Test pour avec 2 comptes courant et un compte epargne
            CompteCourant compteNicolas = new CompteCourant("Nicolas", 2000, cab);
            CompteCourant compteJeremy = new CompteCourant("Jeremy", 500, cab);
            CompteEpargne compteEpargneNicolas = new CompteEpargne("Nicolas", 0.05m, cbftf);

            //Test Livret
            Livret livretNicolas = new Livret("Nicolas", cba);


            compteNicolas.Crediter(1000);
            compteNicolas.Debiter(50);
            compteEpargneNicolas.Crediter(50);
            compteNicolas.Crediter(100);
            compteEpargneNicolas.Crediter(100);
            compteJeremy.Debiter(500);
            compteJeremy.Debiter(200, compteNicolas);
            livretNicolas.Crediter(800);
            livretNicolas.Crediter(200);

            compteNicolas.AfficherResume();
            Console.WriteLine("");
            compteJeremy.AfficherResume();
            Console.WriteLine("");
            compteEpargneNicolas.AfficherResume();
            Console.WriteLine("");
            livretNicolas.AfficherResume();
            Console.WriteLine("");


            Console.ReadKey();
        }
    }
}
