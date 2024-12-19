using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assurance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ce programme permet l'utilisateur de saisir le montant des domamages, afficher ensuite le montant qui sera\r\nrembourser ainsi que la franchise");
            Console.WriteLine("Entrez le montant des dommages :");
            // Lire et convertir l'entrée utilisateur en décimal
            decimal montantDommages;
            while (!decimal.TryParse(Console.ReadLine(), out montantDommages) || montantDommages < 0)
            {
                Console.WriteLine("Veuillez entrer un montant valide.");
            }
            // Calculer la franchise 10% du montant des dommages
            decimal franchise = montantDommages * 0.10m;
            // S'assurer que la franchise ne dépasse pas 4000 euros
            if (franchise > 4000)
            {
                franchise = 4000;
            }
            // Calculer le montant remboursé
            decimal montantRembourse = montantDommages - franchise;
            // Afficher les résultats
            Console.WriteLine($"\nMontant des dommages : {montantDommages} euros");
            Console.WriteLine($"Franchise : {franchise} euros");
            Console.WriteLine($"Montant remboursé : {montantRembourse} euros");
        }
    }
    
}
