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
            int contHospedes = hospedes.Count;
            if (contHospedes <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else if(contHospedes > Suite.Capacidade)
            {
                // TODO: Retornar uma exception caso a capacidade seja maior que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
                throw new ExcecaoPersonalizada("Erro! a pacacidade maxima para essa suite é de dois hospedes");
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
            int contHospedes = Hospedes.Count;
            return contHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10)
            {
                decimal valorComDesc = valor - (valor * 0.10m);
                return valorComDesc;
            }

            return valor;
        }


        public override string ToString()
        {
            return "Quantidade de hospedes: " + ObterQuantidadeHospedes() 
                    + "\nValor da diária: " + CalcularValorDiaria();
        }
    }
}