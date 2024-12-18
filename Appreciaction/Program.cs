using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appreciaction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            string rep;
            Console.WriteLine("Ce programme pernet d'apprecier votre age");
            do {
                Console.WriteLine("Saisir votre age :");
                age = int.Parse(Console.ReadLine());
                Console.WriteLine(Apprecier(age));
                Console.WriteLine("Pour quitter saisir Q");
                rep = Console.ReadLine();
            }
            while (rep.ToUpper()!= "Q");
            
        }

        /// <summary>
        /// cette methode permet d'appecier votre age
        /// </summary>
        /// <param name="age">saisir age</param>
        /// <returns>retourne appreciation</returns>

        public static string Apprecier(int age) {

            if (age < 16)
            {

                return "Vous etes mineur";
            }
            else if (age > 35)
            {
                return "Vous etes adolescent";
            }
            else {

                return "Vous etes adult";
            }
        }
    }
}
