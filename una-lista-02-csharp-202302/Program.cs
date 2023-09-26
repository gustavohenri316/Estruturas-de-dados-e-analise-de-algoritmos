using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nLista de Exercícios II: Estrutura Sequencial - Escolha a Atividade");
            Console.WriteLine("1. Atividade-01");
            Console.WriteLine("2. Atividade-02");
            Console.WriteLine("3. Atividade-03");
            Console.WriteLine("4. Atividade-04");
            Console.WriteLine("5. Atividade-05");
            Console.WriteLine("6. Atividade-06");
            Console.WriteLine("7. Atividade-07");
            Console.WriteLine("8. Atividade-08");
            Console.WriteLine("9. Atividade-09");
            Console.WriteLine("10. Atividade-10");
            Console.WriteLine("0. Sair");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "0":
                    Console.WriteLine("---> Aplicação encerrada!");
                    return;
                case "1":
                    Atividade1();
                    break;
                case "2":
                    Atividade2();
                    break;
                case "3":
                    Atividade3();
                    break;
                case "4":
                    Atividade4();
                    break;
                case "5":
                    Atividade5();
                    break;
                case "6":
                    Atividade6();
                    break;
                case "7":
                    Atividade7();
                    break;
                case "8":
                    Atividade8();
                    break;
                case "9":
                    Atividade9();
                    break;
                case "10":
                    Atividade10();
                    break;
                default:
                    Console.WriteLine("---> Opção inválida!");
                    break;
            }
        }
    }

    static void Atividade1()
    {
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("Atividade 01 - Média Aritmética de dois números");
        Console.WriteLine("Informe o primeiro número:");
        double primeiroNumero = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o segundo número:");
        double segundoNumero = Convert.ToDouble(Console.ReadLine());

        double media = (primeiroNumero + segundoNumero) / 2.0;

        Console.WriteLine($"A média aritmética de {primeiroNumero} e {segundoNumero} é igual a: {media}");
        Console.WriteLine("----------------------------------------------------------------------");
    }

    static void Atividade2()
    {
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("Atividade 02 - Acrescimo de 10% no produto");
        Console.WriteLine("Informe o valor em reais do produto:");
        double valor = Convert.ToDouble(Console.ReadLine());

        double novoValor = valor * 1.10;

        Console.WriteLine($"Novo valor do produto {novoValor:C}");
        Console.WriteLine("----------------------------------------------------------------------");
    }

    static void Atividade3()
    {
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("Atividade 03 - Conversão de temperatura (graus Fahrenheit --> graus centígrados)");
        Console.WriteLine("Informe a temperatura em Fahrenheit:");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        double centigrados = (fahrenheit - 32) / 1.8;

        Console.WriteLine($"A temperatura em graus centígrados é igual a:  {centigrados:F2}");
        Console.WriteLine("----------------------------------------------------------------------");
    }

    static void Atividade4()
    {
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("Atividade 04 - Calculo de juros composto de uma aaplicação");

        Console.WriteLine("Informe o valor do caapital a ser aplicado:");
        double capital = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o prazo da aplicação em meses:");
        int meses = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a taxa de juros mensal:");
        double taxa = Convert.ToDouble(Console.ReadLine());

        double montante = capital * Math.Pow(1 + taxa, meses);

        Console.WriteLine($"O montante a ser recebido é de: {montante:C}");
        Console.WriteLine("----------------------------------------------------------------------");
    }

    static void Atividade5()
    {
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("Atividade 05 - Cálculo de Salário Bruto");

        Console.WriteLine("Informe o mês de referência:");
        String mes = Console.ReadLine();

        Console.WriteLine($"Informe o número de horas que o funcionário trabalhou no mês de {mes}:");
        double horas = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o valor a ser recebido por hora de trablho:");
        double valorHora = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe valor do salário faamília:");
        double salarioFamilia = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o número de filhos com idade menor que 14 anos:");
        double filhos = Convert.ToInt32(Console.ReadLine());

        double salarioBruto = (horas * valorHora) + (salarioFamilia * filhos);

        Console.WriteLine($"Salário Bruto - {mes} : {salarioBruto:C}");

        Console.WriteLine("----------------------------------------------------------------------");
    }

    static void Atividade6()
    {
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("Atividade 06 - Logaritmo");

        Console.WriteLine("Informe o número para calcular o Logaritmo:");
        double numero = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe a base:");
        double logBase = Convert.ToDouble(Console.ReadLine());

        double log = Math.Log(numero, logBase);

        Console.WriteLine($"Logaritmo de {numero} na base {logBase}: {log}");

        Console.WriteLine("----------------------------------------------------------------------");
    }

    static void Atividade7()
    {
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("Atividade 07 - Salário Total Vendedor");

        Console.WriteLine("Informe o salário fixo do vendedor:");
        double salarioFixo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o valor total das vendas realizadas no mês:");
        double valorVendas = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o percentual de ganho sobre o total das vendas:");
        double percentual = Convert.ToDouble(Console.ReadLine());

        double salarioTotal = salarioFixo + (valorVendas * percentual / 100);

        Console.WriteLine($"Salário Total: {salarioTotal:C}");

        Console.WriteLine("----------------------------------------------------------------------");
    }

    static void Atividade8()
    {
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("Atividade 08 - Estacionamento");

        Console.WriteLine("Informe a quantidade total de veículos no estacionamento:");
        int veiculos = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a quantidade total de rodas:");
        int rodas = Convert.ToInt32(Console.ReadLine());

        int carros = 0;
        int motos = 0;

        while (rodas >= 4 && veiculos > 0)
        {
            carros++;
            rodas -= 4;
            veiculos--;
        }

        motos = veiculos;

        Console.WriteLine($"Total de carros: {carros}");
        Console.WriteLine($"Total de motos: {motos}");

        Console.WriteLine("----------------------------------------------------------------------");
    }

    static void Atividade9()
    {
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("Atividade 09 - Horas / Minutos / Segundos");

        Console.WriteLine("Informe uma hora em segundos:");
        int segundosInformado = Convert.ToInt32(Console.ReadLine());

        int horas = segundosInformado / 3600;
        int minutos = (segundosInformado % 3600) / 60;
        int segundos = segundosInformado % 60;

        Console.WriteLine($"--> {horas}:{minutos}:{segundos}");

        Console.WriteLine("----------------------------------------------------------------------");
    }

    static void Atividade10()
    {
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("Atividade 10 - Médias aritmética, harmônica e geométrica ");
        Console.WriteLine("Informe o valor a:");
        double valorA = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o valor b:");
        double valorB = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o valor c:");
        double valorC = Convert.ToDouble(Console.ReadLine());

        double medAr = (valorA + valorB + valorC) / 3;
        double medHar = 3 / (1 / valorA + 1 / valorB + 1 / valorC);
        double medGeom = Math.Pow(valorA * valorB * valorC, 1.0 / 3.0);

        Console.WriteLine($" Média Aritimética: {medAr}");
        Console.WriteLine($" Média Harmônica: {medHar}");
        Console.WriteLine($" Média Geométrica: {medGeom}");

        Console.WriteLine("----------------------------------------------------------------------");
    }

}
