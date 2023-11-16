using System;

class ShellSort
{
    public static void Executar()
    {
        int[] vetor = { 1, 100, 30, 50, 11, 13, 5, 7, 78 };

        Console.WriteLine("\nVetor não ordenado:");
        foreach (int elemento in vetor)
        {
            Console.Write(elemento + " ");
        }

        AlgoritmoInsertionSort(vetor);

        Console.WriteLine("\nVetor ordenado pelo Shell Sort:");
        foreach (int elemento in vetor)
        {
            Console.Write(elemento + " ");
        }
    }

    static void AlgoritmoInsertionSort(int[] vetor)
    {
        int size = vetor.Length;
        int gap = 1;

        while (gap < size)
        {
            gap = 3 * gap + 1;
        }

        while (gap > 1)
        {
            gap /= 3;
            for (int i = gap; i < size; i++)
            {
                int value = vetor[i];
                int j = i - gap;

                while (j >= 0 && value < vetor[j])
                {
                    vetor[j + gap] = vetor[j];
                    j -= gap;
                }

                vetor[j + gap] = value;
            }
        }
    }
}