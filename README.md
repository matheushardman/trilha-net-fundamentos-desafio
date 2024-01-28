# DIO - Trilha .NET - Desafio Fundamentos
O desafio consiste em construir um sistema para estacionamento que será utilizado para gerenciar veículos estacionados, podendo assim adicionar um veículo, listar os veículos que estão estacionados e remover um veículo do mesmo (calculando o valor cobrado durante o período de tempo estacionado).

### :desktop_computer: Tecnologias Utilizadas

- C#
- .NET

## Requisitos
Proposta: Construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:
![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar

### Solução

O código original fornecido foi ajustado para obedecer as regras descritas acima utilizando os fundamentos de C# e .NET, as variáveis precoInicial e precoPorHora foram definidas como private (garantindo o encapsulamento) e um construtor foi definido para que essas duas variáveis sejam indicadas na instância de um objeto Estacionamento. Além das regras estabelecidas, no método AdicionarVeiculo foram implementadas duas melhorias: A verificação se um veículo com aquela placa já estaria estacionado para evitar erros de digitação do usuário do sistema, já a segunda melhoria foi a validação da placa do veículo de acordo com o novo modelo do Mercosul.

## Instruções de Uso

1. Clonar o repositório atual para sua máquina local

   `git clone https://github.com/matheushardman/trilha-net-fundamentos-desafio.git`

2. Caso não tenha o .NET 6.0 ou superior instalado, certifique-se instalar, você pode encontrá-lo em:

   `https://dotnet.microsoft.com/pt-br/download/dotnet/6.0`

3. Abra o projeto clonado em sua IDE ou editor de código-fonte de preferência

4. Abra o terminal e vá para pasta DesafioFundamentos

   `cd DesafioFundamentos`

5. Execute o projeto com o seguinte comando

   `dotnet run`
