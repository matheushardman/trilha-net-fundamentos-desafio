using System.Text.RegularExpressions;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = "";
            placa = Console.ReadLine();
            placa = placa.ToUpper();
            // Verifica se já existe um veículo estacionado com a placa indicada
            if (!veiculos.Any(x => x.ToUpper() == placa))
                //Valida a placa de acordo com o novo padrão do Mercosul
                if(ValidarPlaca(placa))
                {
                    veiculos.Add(placa);
                }
                else
                {
                    Console.WriteLine("Placa inválida. Por favor, retorne ao Menu e insira uma placa do Mercosul válida Exemplo: [AAA0A00] na opção 1 - Cadastrar veículo.");
                }
            else
            {
                Console.WriteLine("Esse veículo já está dentro do estacionamento");
            }

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = "";
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = 0;
                decimal valorTotal = 0; 
                horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = precoInicial + precoPorHora * horas;
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
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
                foreach(string veiculo in veiculos)
                {
                    Console.WriteLine($"{veiculo}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        public bool ValidarPlaca(string placa)
        {
            string placaMercosul = @"^[A-Z]{3}[0-9][A-Z][0-9]{2}$";
            bool validacaoPlaca = Regex.IsMatch(placa, placaMercosul);
            return validacaoPlaca;
        }
    }
}
