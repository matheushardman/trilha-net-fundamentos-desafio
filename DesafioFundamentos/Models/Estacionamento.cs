using System.Dynamic;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

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
        public override string ToString()
        {
            return $"Placa: {placa}\nHorario de Entrada: {horarioEntrada}\nHorario de Saida: {horarioSaida}\nValor do estacionamento: R${valor}";
        }
        public decimal GetValor()
        {
            return valor;
        }
    }
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private Dictionary<string, DateTime> veiculos = new Dictionary<string, DateTime>();
        private List<Ticket> historicoTickets = new List<Ticket>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo(string placa)
        {
            // Verifica se já existe um veículo estacionado com a placa indicada
            if (!veiculos.ContainsKey(placa))
            {
                //Valida a placa de acordo com o padrão de placa utilizado no Brasil, tanto no modelo antigo quanto no novo modelo do Mercosul
                if(ValidarPlaca(placa))
                {
                    //veiculos.Add(placa);
                    veiculos.Add(placa, DateTime.Now);
                }
                else
                {
                    Console.WriteLine("Placa inválida. Por favor, retorne ao Menu e insira uma placa válida na opção 1 - Cadastrar veículo. Exemplo: [LLLNLNN] ou [LLL-NNNN] onde L é letra e N é número");
                }
            }
            else
            {
                Console.WriteLine("Esse veículo já está dentro do estacionamento, verifique se a placa está correta");
            }

        }

        public void RemoverVeiculo(string placa)
        {
            // Verifica se o veículo existe
            if(veiculos.ContainsKey(placa))
            {
                    //var horarioEntrada = new DateTime(2024, 01, 30, 13, 30, 00);
                    DateTime horarioEntrada = veiculos[placa];
                    DateTime horarioSaida = DateTime.Now;
                    TimeSpan intervaloTempo = horarioSaida.Subtract(horarioEntrada);
                    int totalHoras = (int)Math.Ceiling(intervaloTempo.TotalHours);
                    decimal valorTotal = precoInicial + precoPorHora * totalHoras;
                    veiculos.Remove(placa);
                    Ticket ticket = new Ticket(placa, horarioEntrada, horarioSaida, valorTotal);
                    historicoTickets.Add(ticket);
                    Console.WriteLine($"O veículo {placa} foi removido, o tempo estacionado foi de {totalHoras} horas e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach(var veiculo in veiculos)
                {
                    Console.WriteLine($"{veiculo.Key}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        public void Historico()
        {
            Console.Clear();
            decimal somaValorTicket = 0;
            foreach(var ticket in historicoTickets)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine($"{ticket}");
                somaValorTicket += ticket.GetValor();
            }
            Console.WriteLine("=================================================");
            Console.WriteLine($"O valor total de receitas foi de R$ {somaValorTicket}");
            Console.WriteLine("=================================================");
        }

        private bool ValidarPlaca(string placa)
        {
            string modeloPlaca = @"^[A-Z]{3}[0-9][A-Z0-9][0-9]{2}$|^[A-Z]{3}-[0-9]{4}$";
            bool placaValida = Regex.IsMatch(placa, modeloPlaca);
            return placaValida;
        }
    }
}
