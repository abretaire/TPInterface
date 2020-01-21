using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPInterface
{
    public abstract class Compte
    {
        protected ICalculateurDeBenefice _calculateurDeBenefice;

        public string Proprietaire { get; set; }

        public virtual decimal Solde
        {
            get
            {
                decimal solde = 0;

                foreach (Operation operation in _operations)
                {
                    if (operation.Type == TypeOperation.credit)
                    {
                        solde = solde + operation.Montant;
                    }
                    else
                    {
                        solde = solde - operation.Montant;
                    }
                }

                return _calculateurDeBenefice.CalculBenefice(solde);
            }
        }

        protected List<Operation> _operations; // C'est une liste générique. Entre les < et > on met ce que l'on veut mettre dans la liste, ici des opérations mais ça pourrait être des pommes. C'est plus intéressant qu'un tableau car elle grossit indéfiniment.

        public Compte(string proprietaire, ICalculateurDeBenefice calculateurDeBenefice)
        {
            Proprietaire = proprietaire;
            _calculateurDeBenefice = calculateurDeBenefice;
            _operations = new List<Operation>();
        }

        public void Crediter(decimal somme)
        {
            AjouterMouvement(somme, TypeOperation.credit);
        }

        public void Crediter(decimal somme, Compte compteDebitant)
        {
            AjouterMouvement(somme, TypeOperation.credit);
            compteDebitant.Debiter(somme);
        }

        public void Debiter(decimal somme)
        {
            AjouterMouvement(somme, TypeOperation.debit);
        }

        public void Debiter(decimal somme, Compte compteCreditant)
        {
            AjouterMouvement(somme, TypeOperation.debit);
            compteCreditant.Crediter(somme);
        }

        /*public void AfficherResume()
        {
            Console.WriteLine(string.Format("Résumé du compte de {0}", Proprietaire));
            Console.WriteLine("*************************************");
            Console.WriteLine(string.Format("Solde : {0}", Solde.ToString("N2")));
            Console.WriteLine("Opérations :");
            AfficheOperations();
            Console.WriteLine("*************************************");
        }*/

        public abstract void AfficherResume();

        protected void AfficheOperations()
        {
            foreach (Operation operation in _operations)
            {
                if (operation.Type == TypeOperation.credit)
                {
                    Console.WriteLine(string.Format("+{0}", operation.Montant.ToString("N2")));
                }
                else
                {
                    Console.WriteLine(string.Format("-{0}", operation.Montant.ToString("N2")));
                }
            }
        }

        private void AjouterMouvement(decimal somme, TypeOperation type)
        {
            Operation operation = new Operation { Montant = somme, Type = type };

            _operations.Add(operation);
        }
    }
}
