using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3glGroupe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom, prenom, email;
            Console.WriteLine("Ce programme vous souhaite la bienvenue");
            Console.WriteLine("Donnez votre nom :");
            nom = Console.ReadLine();
            Console.WriteLine("Donnez votre prenom :");
            prenom = Console.ReadLine();
            Console.WriteLine("Donnez votre email :");
            email = Console.ReadLine();
            Console.WriteLine(string.Format("Bonjour {0} {1}, votre email est {2}", prenom, nom, email));
            Console.ReadLine();
        }
    }
}
