using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
decimal precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
decimal precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Historico Gerencial");
    Console.WriteLine("5 - Encerrar");

string placa = string.Empty;

    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placa = Console.ReadLine().ToUpper();
            es.AdicionarVeiculo(placa);
            break;

        case "2":
            Console.WriteLine("Digite a placa do veículo para remover:");
            placa = Console.ReadLine().ToUpper();
            es.RemoverVeiculo(placa);
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            es.GerarHistorico();
            break;

        case "5":
            exibirMenu = false;
            break;


        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
