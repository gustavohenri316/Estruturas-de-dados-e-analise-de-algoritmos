using System;

class Atividade01
{

    public static void Executar()
    {

        int[] vetor = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Informe o {i + 1} número: ");
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("");
        Console.WriteLine("Números digitados:");
        foreach (int numero in vetor)
        {
            Console.WriteLine(numero);
        }

    }
}