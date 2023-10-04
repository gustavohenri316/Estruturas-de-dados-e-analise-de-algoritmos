using System;

class Atividade05
{
    public static void Executar()
    {
        const int tamanhoVetor = 20;
        int[] numeros = new int[tamanhoVetor];
        int[] pares = new int[tamanhoVetor];
        int[] impares = new int[tamanhoVetor];
        for (int i = 0; i < tamanhoVetor; i++)
        {
            Console.Write($"Digite o {i + 1}º número inteiro: ");
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] % 2 == 0)
            {
                pares[i] = numeros[i];
            }
            else
            {
                impares[i] = numeros[i];
            }
        }

    
        Console.WriteLine("\nNúmeros Digitados:");
        ImprimirVetor(numeros);
        Console.WriteLine("\nNúmeros Pares:");
        ImprimirVetor(pares);
        Console.WriteLine("\nNúmeros Ímpares:");
        ImprimirVetor(impares);
        Console.ReadKey();
    }

    static void ImprimirVetor(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] != 0)
            {
                Console.Write(vetor[i] + " ");
            }
        }
        Console.WriteLine();
    }
}
