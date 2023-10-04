using System;

class Atividade04
{

    public static void Executar()
    {
        char[] caracteres = new char[10];
        int consoante = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Informe o {i + 1}º caractere: ");
            caracteres[i] = Convert.ToChar(Console.ReadLine());
        }

        Console.Write("-- Consoantes:");
        foreach (char c in caracteres)
        {
            if (char.IsLetter(c) && !"AEIOUaeiou".Contains(c))
            {
                Console.Write($"{c} / ");
                consoante++;
            }
        }

        Console.WriteLine($"-- Quantidade de consoantes: {consoante} \n");

    }
}