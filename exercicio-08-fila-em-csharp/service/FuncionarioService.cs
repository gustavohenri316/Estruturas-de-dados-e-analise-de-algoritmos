class FuncionarioService
{
    public static void Adicionar(List<Funcionario> funcionarios)
    {
        String nome;
         do
        {
            Console.WriteLine(" - Informe o nome do funcionario:");
            nome = Console.ReadLine();

            if (string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("Erro: O nome do Funcionário não pode ser vazio. Por favor, insira um nome válido.");
            }
        } while (string.IsNullOrEmpty(nome));

        funcionarios.Add(new Funcionario(nome));
        Console.WriteLine("Funcionario " + nome + " adicionado com sucesso!");
    }

}