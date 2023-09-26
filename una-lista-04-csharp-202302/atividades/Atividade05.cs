using System;

class Atividade05
{

    public static void Executar()
    {
        Console.WriteLine("");
        Console.WriteLine("Atividade 05 - Números ímpares entre 1 e 50");

        int numeros = 50;

        for (int i = 1; i <= numeros; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine($"{i}");
            }
        }

    }
}