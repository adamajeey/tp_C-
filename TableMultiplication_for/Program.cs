using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableMultiplication_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            string rep;
            Console.WriteLine("Ce programme pernet de faire la table de multiplication d'un nombre");
            do
            {
                Console.WriteLine("Saisir le nombre :");
                n = int.Parse(Console.ReadLine());
                multiplier(n);
                Console.WriteLine("Pour quitter saisir Q");
                rep = Console.ReadLine();
            }
            while (rep.ToUpper() != "Q");
        }

        /// <summary>
        /// Cette methode permet de retourner le table de multiplication d'un nombre 
        /// </summary>
        /// <param name="n">sasir le nombre</param>

        public static void multiplier(int n) {

            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine(string.Format("{0} * {1} + {2}", n, i, n*i));
            }

        }
    }
}
