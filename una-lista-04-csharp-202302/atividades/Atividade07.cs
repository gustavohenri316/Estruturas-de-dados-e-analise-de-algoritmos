using System;

class Atividade07
{

    public static void Executar()
    {
        Console.WriteLine("");
        Console.WriteLine("Atividade 07 - Números pares e ímpares");

        int par = 0;
        int impar = 0;

        for (int i = 0 + 1; i <= 10; i++)
        {
            Console.WriteLine($"Informe nuemro {i}: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (i % 2 == 0)
            {
                par++;
            }
            else if (i % 2 != 0)
            {
                impar++;
            }
        }

        Console.WriteLine($"Quantidade de números par: {par} ");
        Console.WriteLine($"Quantidade de números ímpar: {impar} \n");

    }

}