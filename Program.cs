using System;
using LeetCodeProblems.Problems;
using LeetCodeProblems.TestCases;

namespace LeetCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o problema para testar:");
            Console.WriteLine("1 - Two Sum");
            Console.WriteLine("2 - Outro Problema");
            Console.Write("Opção: ");
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    var twoSumTest = new TwoSumTest();
                    twoSumTest.Run();
                    break;

                case "2":
                    var outro = new AnotherProblemTest();
                    //outro.Run();
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

    }
}
