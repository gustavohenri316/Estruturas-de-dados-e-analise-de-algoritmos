using System;

class Atividade03
{

    public static void Executar()
    {
        double[] vetor = new double[4];
        double soma = 0;

        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Informe a {i + 1} nota: ");
            vetor[i] = Convert.ToDouble(Console.ReadLine());
            soma += vetor[i];
        }

        Console.WriteLine("-- Números digitados:");
        foreach (int numero in vetor)
        {
            Console.Write($"{numero} / ");
        }

        Console.WriteLine("");
        Console.WriteLine($"-- Media: {soma / vetor.Length}");
    }
}