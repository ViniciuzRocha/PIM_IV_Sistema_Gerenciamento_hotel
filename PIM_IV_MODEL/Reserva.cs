using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_IV_MODEL
{
    public class Reserva
    {
        private int id_reserva;
        private int quarto;
        private DateTime entrada;
        private DateTime saida;
        private string hospede;
        private int valor;
        private string status;
        public Reserva()
        {

        }
        public Reserva(int Reserva, int Quarto, DateTime Entrada, DateTime Saida, string Hospede, int Valor,
            string Status
            )
        {
            id_reserva = Reserva;
            quarto = Quarto;
            entrada = Entrada;
            saida = Saida;
            hospede = Hospede;
            valor = Valor;
            status = Status;
        }
        public int rID_Reserva { get => id_reserva; set => id_reserva = value; }
        public int rQuarto { get => quarto; set => quarto = value; }
        public DateTime rEntrada { get => entrada; set => entrada = value; }
        public DateTime rSaida { get => saida; set => saida = value; }
        public string rHospede { get => hospede; set => hospede = value; }
        public int rValor { get => valor; set => valor = value; }
        public string rStatus { get => status; set => status = value; }
        public void CalcularDiaria()
        {
            int dias = int.Parse(rSaida.Date.Subtract(rEntrada.Date).TotalDays.ToString());
            rValor = dias * 150;

        }
    }
    
}
