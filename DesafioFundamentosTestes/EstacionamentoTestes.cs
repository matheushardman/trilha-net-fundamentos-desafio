using DesafioFundamentos.Models;

namespace DesafioFundamentosTestes;

public class EstacionamentoTestes
{
    [Fact]
    public void DeveAdicionarVeiculoComPlacaValida()
    {
        //Arrange
        Estacionamento estacionamento = new Estacionamento(5,2);
        //var horarioEntrada = DateTime.Now;
        var placa = "AAA-0000";
        //Act
        estacionamento.AdicionarVeiculo(placa);

        //Assert
        Assert.Contains(placa, estacionamento.veiculos.Keys);

    }
    [Fact]
    public void NaoDeveAdicionarVeiculoComPlacaInvalida()
    {
        //Arrange
        
        //Act

        //Assert
    }
    [Fact]
    public void DeveValidarPlacaValida()
    {
        //Arrange
        
        //Act

        //Assert

    }
    [Fact]
    public void NaoDeveValidarPlacaInvalida()
    {
        //Arrange
        
        //Act

        //Assert

    }
    [Fact]
    public void DeveRemoverVeiculoExistenteNoEstacionamento()
    {
        //Arrange
        
        //Act

        //Assert

    }
    [Fact]
    public void NaoDeveRemoverVeiculoInexistenteNoEstacionamento()
    {
        //Arrange
        
        //Act

        //Assert
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