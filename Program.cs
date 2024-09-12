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

// Método para cadastrar suítes 

Suite CadastrarSuite()
{
    System.Console.WriteLine("Tipos de suítes: Premium, Convencional e Economica");
    System.Console.Write("Informe o tipo da suite: ");
    string tipoSuite = Console.ReadLine();

    int capacidade;
    System.Console.WriteLine("A capacidade máxima para cada suíte é de 2 pessoas.");
    while (true)
    {
        System.Console.Write("Informe a capacidade de pessoas que irão utilizar a suíte: ");
        if(int.TryParse(Console.ReadLine(), out capacidade) && capacidade <= 2)
        {
            break;
        }
        System.Console.WriteLine("Capacidade inválida. Tente novamente.");
    }

    return new Suite(tipoSuite, capacidade);
}

// Método para cadastrar reservas
Reserva CadastrarReserva(Suite suite, List<Pessoa> hospedes)
{
    int diasReservados;
    while(true)
    {
        System.Console.Write("Informe o número de dias reservados: ");
        if (int.TryParse(Console.ReadLine(), out diasReservados) && diasReservados > 0)
        {
            break;
        }
        System.Console.WriteLine("Número de dias inválido. Tente novamente.");
    }

    Reserva reserva = new Reserva(diasReservados);
    reserva.CadastrarSuite(suite);
    reserva.CadastrarHospedes(hospedes);

    return reserva;
}

// Método para gerenciar cadastro de múltiplas reservas
void GerenciarReservas()
{
    List<Reserva> reservas = new List<Reserva>();
    string continuar = "S";

    while(continuar.Equals("S", StringComparison.OrdinalIgnoreCase))
    {
        
    }
}

