using Models;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite SuiteReservada { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
            Hospedes = new List<Pessoa>();
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            Hospedes = hospedes;
        }

        public void CadastrarSuite(Suite suite)
        {
            SuiteReservada = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            decimal valortotal = DiasReservados * SuiteReservada.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if (DiasReservados >= 10)
            {
                decimal valorComDesc = valortotal - (valortotal * 0.10m);
                return valorComDesc;
            }

            return valortotal;
        }


        public override string ToString()
        {
            return "Reserva para " + ObterQuantidadeHospedes() + " hóspede(s)" +
                   "\n Dias Reservados: " + DiasReservados +
                   "\n Valor Total: " + CalcularValorDiaria();
        }
    }
}