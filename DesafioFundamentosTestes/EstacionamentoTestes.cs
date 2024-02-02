using DesafioFundamentos.Models;

namespace DesafioFundamentosTestes;

public class EstacionamentoTestes
{
    [Fact]
    public void DeveAdicionarVeiculoComPlacaValida()
    {
        //Arrange
        Estacionamento estacionamento = new Estacionamento(5, 2);
        string placa = "AAA-0000";

        //Act
        estacionamento.AdicionarVeiculo(placa);

        //Assert
        Assert.True(estacionamento.VeiculoJaEstacionado(placa));

    }
    [Fact]
    public void NaoDeveAdicionarVeiculoComPlacaInvalida()
    {
        //Arrange
        Estacionamento estacionamento = new Estacionamento(5, 2);
        string placa = "AAA-000";
        
        //Act
        estacionamento.AdicionarVeiculo(placa);

        //Assert
        Assert.False(estacionamento.VeiculoJaEstacionado(placa));
    }
    [Fact]
    public void DeveRemoverVeiculoExistenteNoEstacionamento()
    {
        //Arrange
        Estacionamento estacionamento = new Estacionamento(5, 2);
        string placa = "AAA-0000";
        estacionamento.AdicionarVeiculo(placa);
        
        //Act
        estacionamento.RemoverVeiculo(placa);

        //Assert
        Assert.False(estacionamento.VeiculoJaEstacionado(placa));

    }
    [Fact]
    public void NaoDeveRemoverVeiculoInexistenteNoEstacionamento()
    {
        //Arrange
        Estacionamento estacionamento = new Estacionamento(5, 2);
        string placa = "AAA-000";
        estacionamento.AdicionarVeiculo(placa);
        
        //Act
        estacionamento.RemoverVeiculo(placa);

        //Assert
        Assert.False(estacionamento.VeiculoJaEstacionado(placa));
    }
    [Fact]
    public void DeveListarVeiculosNoEstacionamento()
    {
        //Arrange
        
        //Act

        //Assert
    }
    [Fact]
    public void NaoDeveListarVeiculosNoEstacionamento()
    {
        //Arrange
        
        //Act

        //Assert

    }
    
}