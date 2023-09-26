using System;

class Atividade01
{

    public static void Executar()
    {

        Console.WriteLine("");
        Console.WriteLine("Atividade 01 - Notas entre 0 e 10");

        do
        {

            Console.WriteLine("Informe uma nota entre 0 e 10:");
            double nota = Convert.ToDouble(Console.ReadLine());

            if (nota > 0 && nota < 10)
            {
                Console.WriteLine($"-- Nota informada: {nota} \n");
                break;
            }
            else
            {
                Console.WriteLine($"-- ERRO - A nota {nota} não esta entre 0 e 10 \n");
            }

        } while (true);

    }
}