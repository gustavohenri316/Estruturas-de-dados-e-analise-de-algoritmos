// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nLista de Exercícios III: Estrutura Condicional - Escolha a Atividade");
            Console.WriteLine("1. Atividade-01");
            Console.WriteLine("2. Atividade-02");
            Console.WriteLine("3. Atividade-03");
            Console.WriteLine("4. Atividade-04");
            Console.WriteLine("5. Atividade-05");
            Console.WriteLine("6. Atividade-06");
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
                default:
                    Console.WriteLine("---> Opção inválida!");
                    break;
            }
        }
    }

    static void Atividade1()
    {
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("Atividade 01 - Números: maior, menor e Média Aritmética");

        Console.WriteLine("Informe o primeiro número:");
        double primeiroNumero = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o segundo número:");
        double segundoNumero = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o terceiro número:");
        double terceiroNumero = Convert.ToDouble(Console.ReadLine());

        double maior = primeiroNumero;
        double menor = primeiroNumero;

        if (segundoNumero > maior)
            maior = segundoNumero;
        if (terceiroNumero > maior)
            maior = terceiroNumero;

        if (segundoNumero < menor)
            menor = segundoNumero;
        if (terceiroNumero < menor)
            menor = terceiroNumero;

        double media = (primeiroNumero + segundoNumero + terceiroNumero) / 3;

        Console.WriteLine($"Média aritmética: {media}");
        Console.WriteLine($"Maior número: {maior}");
        Console.WriteLine($"Menor número: {menor}");
        Console.WriteLine("----------------------------------------------------------------------");
    }

    static void Atividade2()
    {
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("Atividade 02 - Máquina de Vendas");

        Console.WriteLine("Informe o valor da compra:");
        double valorCompra = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o valor pago:");
        double valorPago = Convert.ToDouble(Console.ReadLine());

        if (valorPago < valorCompra)
        {
            Console.WriteLine("A quantia paga é insuficiente para realizar a compra.");
        }
        else
        {
            double troco = valorPago - valorCompra;
            Console.WriteLine($"Troco: {troco:C}");

            int[] notas = { 50, 20, 10, 5, 2, 1 };
            int i = 0;

            while (troco > 0)
            {

                int nota = notas[i];
                int quantidadeNotas = (int)(troco / nota);

                if (quantidadeNotas > 0)
                {
                    Console.WriteLine($" - {nota:C}: {quantidadeNotas} notas");
                    troco %= nota;
                }
                i++;
            }
        }

        Console.WriteLine("----------------------------------------------------------------------");
    }

    static void Atividade3()
    {
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("Atividade 03 - Equação de Segundo Grau");

        Console.WriteLine("Informe o coeficiente A:");
        double coefA = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o coeficiente B:");
        double coefB = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o coeficiente C:");
        double coefC = Convert.ToDouble(Console.ReadLine());

        double delta = coefB * coefB - 4 * coefA * coefC;

        if (coefA == 0 || coefB == 0 && coefC != 0)
        {
            Console.WriteLine("Coeficientes informados incorretos");
        }
        else if (coefA == 0 && coefB != 0)
        {
            Console.WriteLine("Essa é uma equação de primeiro grau");
            Console.WriteLine($"Valor da raiz real: {-coefC / coefB}");
        }

        if (delta < 0)
        {
            Console.WriteLine("Esta equação não possui raízes reais");
        }
        else if (delta == 0)
        {
            Console.WriteLine("Esta equação possui duas raízes reais iguais");
            Console.WriteLine($"Valor das raizes: {-coefB / (2 * coefA)}");
        }
        else if (delta > 0)
        {
            Console.WriteLine("Esta equação possui duas raízes reais diferentes.");
            double raiz1 = (-coefB + Math.Sqrt(delta)) / (2 * coefA);
            double raiz2 = (-coefB - Math.Sqrt(delta)) / (2 * coefA);
            Console.WriteLine($"Primeira raiz real: {raiz1}");
            Console.WriteLine($"Segunda raiz real: {raiz2}");
        }

        Console.WriteLine("----------------------------------------------------------------------");
    }

    static void Atividade4()
    {
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("Atividade 04 - Calculo");

        Console.WriteLine("Escolha uma operação:");
        Console.WriteLine("1 - Calcular perimetro do circulo");
        Console.WriteLine("2 - Calcular area do circulo");
        Console.WriteLine("3 - Calcular volume da esfera");
        double opcao = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o valor do raio:");
        double raio = Convert.ToDouble(Console.ReadLine());

        if (opcao == 1)
        {
            double perimetro = 2 * Math.PI * raio;
            Console.WriteLine($"-- Perimetro: {perimetro}");
        }
        else if (opcao == 2)
        {
            double area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine($"-- Area: {area}");
        }
        else if (opcao == 3)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);
            Console.WriteLine($"-- Volume: {volume}");
        }
        else
            Console.WriteLine("O código de operação é inválido");

        Console.WriteLine("----------------------------------------------------------------------");
    }

    static void Atividade5()
    {
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("Atividade 05 - Operações");

        Console.WriteLine("Informe o primeiro numero real:");
        double numUm = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o segundo numero real:");
        double numDois = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe um dos símbolos para operação:");
        Console.WriteLine(" + Adição");
        Console.WriteLine(" - Subtração");
        Console.WriteLine(" * Multiplicação");
        Console.WriteLine(" / Divisão");
        Console.WriteLine(" ^ Potenciação ");
        char simbolo = Console.ReadLine()[0];

        if (simbolo == '+')
            Console.WriteLine($"-- Adição: {numUm + numDois}");
        else if (simbolo == '-')
            Console.WriteLine($"-- Subtração: {numUm - numDois}");
        else if (simbolo == '*')
            Console.WriteLine($"-- Multiplicação: {numUm * numDois}");
        else if (simbolo == '/')
            Console.WriteLine($"-- Divisão: {numUm / numDois}");
        else if (simbolo == '^')
            Console.WriteLine($"-- Potencição: {Math.Pow(numUm, numDois)}");
        else
            Console.WriteLine("O símbolo de operação é inválido");

        Console.WriteLine("----------------------------------------------------------------------");
    }

    static void Atividade6()
    {
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("Atividade 06 - Sorteio");

        Console.WriteLine("Informe o primeiro numero inteiro:");
        int numUm = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o primeiro numero inteiro:");
        int numDois = Convert.ToInt32(Console.ReadLine());

        int menor = numUm;
        int maior = numUm;

        if (menor > numDois)
            menor = numDois;
        if (maior < numDois)
            maior = numDois;

        Random random = new Random();
        int numSorteado = random.Next(menor, maior + 1);

        if (numSorteado % 2 == 0)
            Console.WriteLine($"O número sorteaoo foi {numSorteado} Este número é par.");
        else
            Console.WriteLine($"O número sorteaoo foi {numSorteado} Este número é impar.");

        Console.WriteLine("----------------------------------------------------------------------");
    }
}
