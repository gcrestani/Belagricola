using Belagricola_02_insertion_sort.Helpers;
using System;
using System.Collections.Generic;

namespace Belagricola_02_insertion_sort
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("QUESTÃO 02: Escreva um algoritmo de ordenação\n" +
            "EXPLICAÇÃO: Data uma lista de números distintos(a sua escolha),\n" + "" +
            "ordene estes números utilizando o método Insertion sort\n");

            Console.WriteLine("Considerando a seguinte lista:");
            Console.WriteLine("27, 5, 48, 12, 3, 125, 35, 1, -5, -992, -12, 0, 45, 100\n");

            int[] numbers = new int[] { 27, 5, 48, 12, 3, 125, 35, 1, -5, -992, -12, 0, 45, 100 };

            numbers = InsertionSort.Sort(numbers);

            Console.WriteLine("A lista ordenada é:");
            Console.WriteLine(string.Join(", ", numbers));
            Console.ReadLine();
        }
    }
}
