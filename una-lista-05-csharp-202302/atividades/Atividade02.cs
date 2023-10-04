using System;

class Atividade02
{

    public static void Executar()
    {
        double[] vetor = new double[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Informe o {i + 1} número: ");
            vetor[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("");
        Console.WriteLine("Números na ordem inversa:");
        for (int i = 9; i >= 0; i--)
        {
            Console.WriteLine(vetor[i]);
        }

    }
}