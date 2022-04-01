using Belagricola_03_caixa_eletronico.Entities;
using System;

namespace Belagricola_03_caixa_eletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUESTÃO 03: Escreva um algoritmo que simule o funcionamento de um caixa eletrônico.\n"+
                "EXPLICAÇÃO: Deverá receber o valor desejado de saque e ele retornará à quantidade de cédulas de cada valor.\n"+
                "As cédulas consideradas pelo caixa eletrônico são: 100, 50, 20, 10, 5 e 2.\n"+
                "Deve ser retornado a menor quantidade de cédulas possível para o valor do saque.\n");

            Console.WriteLine("Por favor, digite o valor do saque:");

            try
            {
                int value = int.Parse(Console.ReadLine());
                if (value > 0)
                {
                    Console.WriteLine(CaixaEletronico.Withdraw(value));
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Por favor verifique o valor inserido. Apenas valores inteiros e positivos são aceitos.");
            }
            Console.ReadLine();
        }
    }
}
