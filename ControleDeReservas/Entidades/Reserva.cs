using System;
using ControleDeReservas.Excecoes;

namespace ControleDeReservas.Entidades
{
    class Reserva
    {
        public int NumQuarto { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }

        public Reserva()
        {

        }

        public Reserva(int numQuarto, DateTime dataEntrada, DateTime dataSaida)
        {
            if (dataSaida <= dataEntrada)
            {
                throw new DominioExcecoes("Data de saída deve ser maior que a data de entrada");
            }

            NumQuarto = numQuarto;
            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
        }

        public int Duracao()
        {
            TimeSpan duracaoDiasData = DataSaida.Subtract(DataEntrada);
            return (int) duracaoDiasData.TotalDays;
        }

        public void AtualizaReserva(DateTime dataEntrada, DateTime dataSaida)
        {
            DateTime now = DateTime.Now;

            if (dataEntrada < now || dataSaida < now)
            {
                throw new DominioExcecoes("Insira datas posteriores a data de hoje para atualizações");
            }
            if (dataSaida <= dataEntrada)
            {
                throw new DominioExcecoes("Data de saída deve ser maior que a data de entrada");
            }

            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
        }

        public override string ToString()
        {
            return "Quarto: " + NumQuarto + ", data de entrada: " + DataEntrada.ToString("dd/MM/yyyy") 
                + ", data de saída: " + DataSaida.ToString("dd/MM/yyyy") + ", duração: " + Duracao() + " noites.";
        }
    }
}
