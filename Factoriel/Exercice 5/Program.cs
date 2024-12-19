using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rep = "";
            // Initialisation de rep
            Console.WriteLine("Ce programme calcule la factorielle d'un nombre."); 
            do { 
                int nombre; 
                long factorielle = 1; 
                Console.WriteLine("Veuillez saisir un nombre :"); 
                while (!int.TryParse(Console.ReadLine(), out nombre)) { 

                    Console.WriteLine("Entrée invalide. Veuillez saisir un nombre entier.");
                } 
                for (int i = 1; i <= nombre; i++) { 

                    factorielle *= i; 

                } 

                Console.WriteLine($"La factorielle de {nombre} est {factorielle}."); 
                Console.WriteLine("Pour quitter, saisir Q. Pour continuer, appuyez sur une autre touche."); 
                rep = Console.ReadLine(); 

            } while (rep.ToUpper() != "Q");

        }
        
    }
}
