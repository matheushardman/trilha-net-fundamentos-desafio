using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Ticket
    {
        private string placa = string.Empty;
        private DateTime horarioEntrada;
        private DateTime horarioSaida;
        private decimal valor;
        public Ticket(string placa, DateTime horarioEntrada, DateTime horarioSaida, decimal valor)
        {
            this.placa = placa;
            this.horarioEntrada = horarioEntrada;
            this.horarioSaida = horarioSaida;
            this.valor = valor;
        }
        public decimal GetValor()
        {
            return valor;
        }
        public override string ToString()
        {
            return $"Placa: {placa}\nHorario de Entrada: {horarioEntrada}\nHorario de Saida: {horarioSaida}\nValor do estacionamento: R${valor}";
        }

    }
}