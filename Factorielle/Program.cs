using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorielle
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Bonjour, ce programme permet de calculer la factorielle d'un nombre.");
            Console.WriteLine("Entrez un nombre pour calculer sa factorielle :");
            // Lire l'entrée utilisateur et la convertir en entier
            int nombre;
            while (!int.TryParse(Console.ReadLine(), out nombre) || nombre < 0)
            {
                Console.WriteLine("Veuillez entrer un entier positif.");
            }
            // Calculer la factorielle
            long factorielle = CalculerFactorielle(nombre);
            // Afficher le résultat
            Console.WriteLine($"La factorielle de {nombre} est {factorielle}");
        }

        /// <summary>
        /// Méthode pour calculer la factorielle d'un nombre donné
        /// </summary>
        /// <param name="n">Nombre entier pour lequel calculer la factorielle</param>
        /// <returns>La factorielle de n</returns>
        /// 
        public static long CalculerFactorielle(int n)
        {  
            long resultat = 1;
           
            for (int i = 1; i <= n; i++)
            {
                resultat *= i;
            }
            return resultat;
        }
    }
}


