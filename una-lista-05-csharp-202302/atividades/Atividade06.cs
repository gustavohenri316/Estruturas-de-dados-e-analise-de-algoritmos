using System;

class Atividade06
{
public static void Executar()
    {
        const int numAlunos = 10;
        double[] medias = new double[numAlunos];
        int alunosAprovados = 0;

        for (int i = 0; i < numAlunos; i++)
        {
            Console.WriteLine($"Digite as quatro notas do aluno {i + 1}:");

            double somaNotas = 0;
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Nota {j + 1}: ");
                double nota = double.Parse(Console.ReadLine());
                somaNotas += nota;
            }

            medias[i] = somaNotas / 4;
            if (medias[i] >= 7.0)
            {
                alunosAprovados++;
            }
        }
        Console.WriteLine("\nMédias dos Alunos:");
        for (int i = 0; i < numAlunos; i++)
        {
            Console.WriteLine($"Aluno {i + 1}: {medias[i]:0.00}");
        }

        Console.WriteLine($"\nNúmero de Alunos com Média Maior ou Igual a 7.0: {alunosAprovados}");
        Console.ReadKey();
    }
}
