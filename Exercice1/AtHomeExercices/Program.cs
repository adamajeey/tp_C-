using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtHomeExercices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom, prenom, email;
            Console.WriteLine("Ce programme vous souhaite la bienvenue");

            Console.WriteLine("Veuillez entrer vos informations suivantes s'il vous plaït");

            Console.WriteLine("Nom :");
            nom=Console.ReadLine();
            Console.WriteLine("Prenom :");
            prenom=Console.ReadLine();
            Console.WriteLine("Eamil :");
            email = Console.ReadLine();

            Console.WriteLine(string.Format("Bonjour {0} {1}, votre email est {2}",prenom, nom, email));
            Console.ReadKey();
        }
    }
}
