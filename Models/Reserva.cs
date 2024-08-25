using Models;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            int conthospedes = hospedes.Count;
            if (conthospedes >= 2 || conthospedes <= 4)
            {
                Hospedes = hospedes;
            }
            else if(conthospedes < 2)
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
                throw new ExcecaoPersonalizada("Erro! a pacacidade minima para essa suite é de dois hospedes");
            }
            else if(conthospedes > 4)
            {
                //Retorna uma exception caso a capacidade seja maior que o número de hóspedes recebido 
                throw new ExcecaoPersonalizada("Erro! a pacacidade maxíma para essa suite é de quatro hospedes");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            int conthospedes = Hospedes.Count;
            return conthospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = 0;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (true)
            {
                valor = 0;
            }

            return valor;
        }
    }
}