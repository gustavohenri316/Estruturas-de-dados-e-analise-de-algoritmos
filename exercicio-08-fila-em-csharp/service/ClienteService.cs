class ClienteService
{
    public static void Adicionar(Queue<Cliente> fila)
    {
        String nome;
         do
        {
            Console.WriteLine(" - Informe o nome do Cliente:");
            nome = Console.ReadLine();

            if (string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("Erro: O nome do Cliente não pode ser vazio. Por favor, insira um nome válido.");
            }
        } while (string.IsNullOrEmpty(nome));

        Cliente cliente = new Cliente(nome);
        fila.Enqueue(cliente);

        Console.WriteLine( nome + " adicionado a fila.");

    }

}