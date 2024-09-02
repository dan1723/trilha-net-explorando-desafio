namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public int Idade { get; set; }

    public Pessoa() { }

    public Pessoa(string nome, string telefone, int idade)
    {
        Nome = nome;
        Telefone = telefone;
        Idade = idade;
    }
    
}