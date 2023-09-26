using System;

class Atividade03
{

    public static void Executar()
    {

        Console.WriteLine("");
        Console.WriteLine("Atividade 03 - Validando informações");

        string nome;
        int idade;
        double salario;
        char sexo;
        char estadoCivil;

        while (true)
        {

            Console.WriteLine("");
            Console.Write("Informe o nome: ");
            nome = Console.ReadLine() ?? "";

            if (nome.Length > 3)
                break;
            else
                Console.WriteLine("TENTE NOVAMENTE: O nome deve ter mais de 3 caracteres.");

        }

        while (true)
        {

            Console.WriteLine("");
            Console.Write("Informe a idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            if (idade >= 0 && idade <= 150)
                break;
            else
                Console.WriteLine("TENTE NOVAMENTE: A idade deve estar entre 0 e 150.");

        }

        while (true)
        {

            Console.WriteLine("");
            Console.Write("Informe o salário:");
            salario = Convert.ToDouble(Console.ReadLine());
            if (salario > 0)
                break;
            else
                Console.WriteLine("TENTE NOVAMENTE: O salário deve ser maior que zero.");

        }

        while (true)
        {

            Console.WriteLine("");
            Console.Write("Informe o sexo(f ou m):");
            char.TryParse(Console.ReadLine(), out sexo);
            if (sexo == 'f' || sexo == 'm')
                break;
            else
                Console.WriteLine("TENTE NOVAMENTE: O sexo deve ser f ou m.");

        }

        while (true)
        {

            Console.WriteLine("");
            Console.Write("Informe o estado civil (s, c, v ou d): \n");
            char.TryParse(Console.ReadLine(), out estadoCivil);
            if (estadoCivil == 's' || estadoCivil == 'c' || estadoCivil == 'v' || estadoCivil == 'd')
                break;
            else
                Console.WriteLine("TENTE NOVAMENTE: o estado civil deve ser s, c, v ou d.");

        }

        Console.WriteLine("");
        Console.WriteLine($" --> Nome: {nome}");
        Console.WriteLine($" --> Idade: {idade}");
        Console.WriteLine($" --> Salário: {salario}");
        Console.WriteLine($" --> Sexo: {sexo}");
        Console.WriteLine($" --> Estado Civil: {estadoCivil} \n");

    }
}