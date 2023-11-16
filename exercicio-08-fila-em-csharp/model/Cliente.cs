class Cliente
{
    public string Nome { get; set; }

    public DateTime  EntradaNaFila { get; set; }
    public int TempoEspera { get; set; }

    public Cliente(string nome)
    {
        Nome = nome;
        EntradaNaFila = DateTime.Now;
    }

}