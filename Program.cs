using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Método para coletar dados do hóspede

Pessoa ColetarDadosHospede()
{
    System.Console.Write("Informe o seu nome: ");
    string nome = Console.ReadLine();
    System.Console.Write("Informe o seu telefone: ");
    string telefone = Console.ReadLine();

    int idade = 0;

    while(true)
    {
        System.Console.Write("Informe a sua idade: ");
        if(int.TryParse(Console.ReadLine(), out idade) && idade > 0)
        {
            break;
        }
        System.Console.Write("Idade invalida. tente novamente");
    }

    return new Pessoa(nome, telefone, idade);
}

// Método para cadastrar hospedes
List<Pessoa> CadastrarHospedes()
{
    List<Pessoa> hospedes = new List<Pessoa>();
    string continuar = "S";

    while (continuar.Equals("S", StringComparison.OrdinalIgnoreCase))
    {
        Pessoa hospede = ColetarDadosHospede();
        hospedes.Add(hospede);

        System.Console.Write("Deseja continuar S/N? ");
        continuar = Console.ReadLine();
        System.Console.WriteLine("-------------------------------------");
        System.Console.WriteLine();
    }

    return hospedes;
}

// Cadastro de hospedes
List<Pessoa> hospedes = CadastrarHospedes();

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hospedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

System.Console.WriteLine(reserva);

