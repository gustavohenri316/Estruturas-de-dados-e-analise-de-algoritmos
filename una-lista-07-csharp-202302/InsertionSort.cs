using System;

class InsertionSort
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

        Console.WriteLine("\nVetor ordenado pelo Insertion Sort:");
        foreach (int elemento in vetor)
        {
            Console.Write(elemento + " ");
        }
    }

    static void AlgoritmoInsertionSort(int[] vetor)
    {
        for (int i = 1; i < vetor.Length; i++)
        {

            int j = i;

            while (j > 0 && vetor[j] < vetor[j - 1])
            {
                int aux = vetor[j];
                vetor[j] = vetor[j - 1];
                vetor[j - 1] = aux;
                j -= 1;
            }
        }
    }
}