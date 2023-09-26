using System;

class Atividade02
{

    public static void Executar()
    {

        Console.WriteLine("");
        Console.WriteLine("Atividade 02 - Usuário e Senha");

        do
        {

            Console.WriteLine("Informe o nome de usuário:");
            string usuario = Console.ReadLine() ?? "";

            Console.WriteLine("Informe a senha:");
            string senha = Console.ReadLine() ?? "";

            if (usuario != senha)
            {
                Console.WriteLine("Usuário e senha informados corretamente! \n");
                break;
            }
            else if (usuario == senha)
            {
                Console.WriteLine("Usuário e senha não podem ser iguais. Tente novamente \n");
            }
            else
            {
                Console.WriteLine("Informações inválidas. Tente novamente \n");
            }

        } while (true);

    }

}