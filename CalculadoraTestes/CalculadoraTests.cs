using Calculadora.Services;
namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImplementacao _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImplementacao();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;

        //Act
        int resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSubtrair10Com5ERetornar5()
    {
        int num1 = 10;
        int num2 = 5;

        int resultado = _calc.Subtrair(num1, num2);

        Assert.Equal(5, resultado);
    }

    [Fact]
    public void DeveDividir10Com5ERetornar2()
    {
        double num1 = 10;
        double num2 = 5;

        double resultado = _calc.Dividir(num1, num2);

        Assert.Equal(2, resultado);
    }
}