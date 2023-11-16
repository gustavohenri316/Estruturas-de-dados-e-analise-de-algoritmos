using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n\nLista de Exercícios VII");
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1. Algoritmo Insertion Sort");
            Console.WriteLine("2. Algoritmo Shell Sort");
            Console.WriteLine("0. Encerrar aplicação");

            string opcao = Console.ReadLine() ?? "";

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("---> Aplicação encerrada!");
                    return;
                case "1":
                    InsertionSort.Executar();
                    break;
                case "2":
                    ShellSort.Executar();
                    break;
                default:
                    Console.WriteLine("---> Opção inválida!");
                    break;
            }
        }
    }
}