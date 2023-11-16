class Program
{
    static void Main()
    {
        Queue<Cliente> fila = new Queue<Cliente>();
        List<Funcionario> funcionarios = new List<Funcionario>();
        DateTime agora = DateTime.Now;
        Random random = new Random();

        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Sistema de Atendimento de Filas");
        Console.WriteLine("-- Sistema iniciado para atendimento: " + agora);
        Console.WriteLine("---------------------------------------------");

        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Adicionar um Funcionário para Atendimento");
            Console.WriteLine("2 - Atualizar um Cliente a Fila de Atendimento");
            Console.WriteLine("3 - Realizar Atendimentos");
            Console.WriteLine("0 - Encerrar Atendimentos");

            string opcao = Console.ReadLine() ?? "";

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("---> Atendimentos encerrado!");
                    return;
                case "1":
                    FuncionarioService.Adicionar(funcionarios);
                    break;
                case "2":
                    ClienteService.Adicionar(fila);
                    break;
                case "3":
                    RealizarAtendimento();
                    break;
                default:
                    Console.WriteLine("---> Opção inválida!");
                    break;
            }
        }

        void RealizarAtendimento()
        {
            while (fila.Count > 0)
            {
                Cliente cliente = fila.Dequeue();
                Funcionario funcionario = funcionarios[random.Next(funcionarios.Count)];
                DateTime tempoAtendimento = DateTime.Now;

                Console.WriteLine(tempoAtendimento + " - Atendendo Cliente: " + cliente.Nome);

                int minutos = random.Next(1, 60);
                tempoAtendimento = tempoAtendimento.AddMinutes(minutos);
                TimeSpan tempoEspera = cliente.EntradaNaFila.Subtract(tempoAtendimento);
                cliente.TempoEspera = (int)Math.Abs(tempoEspera.TotalMinutes);

                Console.WriteLine(tempoAtendimento + " Cliente " + cliente.Nome + " atendido pelo Funcionário " + funcionario.Nome + " com o tempo de " + cliente.TempoEspera + " minutos.");
            }
        }
    }
}