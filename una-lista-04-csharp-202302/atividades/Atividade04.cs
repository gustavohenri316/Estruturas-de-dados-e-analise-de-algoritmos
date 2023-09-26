using System;

class Atividade04
{

    public static void Executar()
    {
        Console.WriteLine("");
        Console.WriteLine("Atividade 04 - Media e Soma de números");

        int quantidade = 5;
        double soma = 0;

        for (int i = 1; i <= quantidade; i++)
        {
            Console.WriteLine($"Informe o número {i}: ");
            double numero = Convert.ToDouble(Console.ReadLine());
            soma = soma + numero;
        }

        Console.WriteLine("");
        Console.WriteLine($"-- Soma: {soma}");
        Console.WriteLine($"-- Média: {soma / 5} \n");

    }

}