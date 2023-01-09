using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsEven
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Witaj użytkowniku, podaj liczbę całkowitą, a ja sprawdzę czy jest ona parzysta czy nie parzysta");
            Console.WriteLine("Podaj liczbę: ");

            var number = GetNumber();

            if (number % 2 == 0)
                {
                    Console.WriteLine("Podana liczba jest parzysta");
                }
                else Console.WriteLine("Podana liczba jest nieparzysta");

                Console.ReadKey();
         
 
        }

        private static int GetNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Podałeś nieprawidłową wartość, wprowadź liczbę: ");
                    continue;
                }

                return number;
            }

        }


    }
}
