using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n\nLista de Exercícios IV: Estrutura de Repetição");
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1. Atividade-01");
            Console.WriteLine("2. Atividade-02");
           
            Console.WriteLine("0. Encerrar aplicação");

            string opcao = Console.ReadLine() ?? "";

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("---> Aplicação encerrada!");
                    return;
                case "1":
                    Atividade01.Executar();
                    break;
             
                default:
                    Console.WriteLine("---> Opção inválida!");
                    break;
            }
        }
    }
}
