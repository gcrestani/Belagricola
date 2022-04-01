using Belagricola_01_soma_par.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Belagricola_01_soma_par
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUESTÃO 01: Escreva um algoritmo que some números pares.\n" +
            "EXPLICAÇÃO: Dada uma lista de números distintos(a sua escolha) encontre a soma dos números\n" +
            "pares que resulte no menor valor, e deve retornar este valor.\n");

            Console.WriteLine("Considerando a seguinte lista:");
            Console.WriteLine("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12");

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };           

            Even evens = new Even(numbers);

            double min = evens.MinSumEvenNumbers();
            Console.WriteLine("A menor soma entre os números pares acima é: " + min.ToString());
            Console.ReadLine();
        }
    }
}
