using System.Diagnostics.Contracts;

namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {

        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        private decimal _valor = 30.00m;
        public decimal ValorDiaria { get{return _valor;}}
        
        public Suite() { }

        public Suite(string tipoSuite, int capacidade)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
        }


        public override string ToString()
        {
            return "Tipo: " + TipoSuite
                  +"\nCapacidade: " + Capacidade
                  +"\nValor da diaria: " + ValorDiaria; 
        }
    }
}