using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Lista de Exercícios IV: Estrutura de Repetição");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Atividade-01");
            Console.WriteLine("2. Atividade-02");
            Console.WriteLine("3. Atividade-03");
            Console.WriteLine("4. Atividade-04");
            Console.WriteLine("5. Atividade-05");
            Console.WriteLine("6. Atividade-06");
            Console.WriteLine("7. Atividade-07");
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
                case "2":
                    Atividade02.Executar();
                    break;
                case "3":
                    Atividade03.Executar();
                    break;
                case "4":
                    Atividade04.Executar();
                    break;
                case "5":
                    Atividade05.Executar();
                    break;
                case "6":
                    Atividade06.Executar();
                    break;
                case "7":
                    Atividade07.Executar();
                    break;
                default:
                    Console.WriteLine("---> Opção inválida!");
                    break;
            }
        }
    }
}
