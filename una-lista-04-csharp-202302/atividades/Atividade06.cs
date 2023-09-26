using System;

class Atividade06
{

    public static void Executar()
    {
        Console.WriteLine("");
        Console.WriteLine("Atividade 06 - Números inteiros");

        Console.WriteLine("");
        Console.WriteLine("Informe o primeiro número inteiro: ");
        int numUm = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o segundo número inteiro: ");
        int numDois = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Números inteiros entre {numUm} e {numDois}: ");
        for (int i = numUm + 1; i < numDois; i++)
        {
            Console.WriteLine($"{i}");
        }
        Console.WriteLine("");
    }
}