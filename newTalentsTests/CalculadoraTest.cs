namespace newTalentsTests;

using System.Net.Http.Headers;
using newTalents.Models;

public class CalculadoraTest
{
    [Theory]
    [InlineData(1,2,3)]
    public void TesteSomar(int num1, int num2, int resultado)
    {
        // Arrange
        Calculadora calc = new Calculadora();

        // Act
        int resultadoTeste = calc.Somar(num1,num2);

        // Assert
        Assert.Equal(resultadoTeste, resultado);
    }

    [Theory]
    [InlineData(2,1,1)]
    public void TesteSubtrair(int num1, int num2, int resultado)
    {
        // Arrange
        Calculadora calc = new Calculadora();

        // Act
        int resultadoTeste = calc.Subtrair(num1,num2);

        // Assert
        Assert.Equal(resultadoTeste, resultado);
    }

    [Theory]
    [InlineData(3,2,6)]
    public void TesteMultiplicar(int num1, int num2, int resultado)
    {
        // Arrange
        Calculadora calc = new Calculadora();

        // Act
        int resultadoTeste = calc.Multiplicar(num1,num2);

        // Assert
        Assert.Equal(resultadoTeste, resultado);
    }

    [Theory]
    [InlineData(4,2,2)]
    public void TesteDividir(int num1, int num2, int resultado)
    {
        // Arrange
        Calculadora calc = new Calculadora();

        // Act
        int resultadoTeste = calc.Dividir(num1,num2);

        // Assert
        Assert.Equal(resultadoTeste, resultado);
    }

    [Fact]
        public void DividirPorZeroRetornaErro()
        {
            Calculadora calc = new Calculadora();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3,0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = new Calculadora();

            calc.Somar(1,2);
            calc.Somar(3,2);
            calc.Somar(5,2);
            calc.Somar(4,2);

            var lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);

        }
}