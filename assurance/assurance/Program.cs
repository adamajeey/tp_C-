using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assurance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Dommages; 
            double franchise; 
            double montantRembourse; 

            Console.WriteLine("Ce programme calcule le montant remboursé par l'assurance en fonction des dommages."); 

            Console.WriteLine("Veuillez saisir le montant des dommages :"); 
            Dommages = double.Parse(Console.ReadLine());


            franchise = Dommages * 0.10; 
            if (franchise > 4000) { 
                franchise = 4000; 
            } 


            montantRembourse = Dommages - franchise; 


            Console.WriteLine($"Montant des dommages : {Dommages} euros"); 
            Console.WriteLine($"Franchise : {franchise} euros"); 
            Console.WriteLine($"Montant remboursé : {montantRembourse} euros");

        }
    }
}
