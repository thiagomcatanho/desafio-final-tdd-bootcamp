using Calculadora.Models;

namespace CalculadoraTest;

public class TesteCalculadora
{
    private readonly CalculadoraImp _calc;

    public TesteCalculadora()
    {
        _calc = new CalculadoraImp();
    }

    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(4, 5, 9)]
    [InlineData(-2, 3, 1)]
    public void TestarSomarEntreDoisNumeros(double numero1, double numero2, double valorEsperado)
    {
        Assert.Equal(valorEsperado, _calc.Somar(numero1, numero2));
    }

    [Theory]
    [InlineData(2, 3, -1)]
    [InlineData(6, 5, 1)]
    [InlineData(-2, 3, -5)]
    public void TestarSubtracaoEntreDoisNumeros(double numero1, double numero2, double valorEsperado)
    {
        Assert.Equal(valorEsperado, _calc.Subtrair(numero1, numero2));
    }

    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(6, 5, 30)]
    [InlineData(-2, 3, -6)]
    public void TestarMultiplicacaoEntreDoisNumeros(double numero1, double numero2, double valorEsperado)
    {
        Assert.Equal(valorEsperado, _calc.Multiplicar(numero1, numero2));
    }

    [Theory]
    [InlineData(6, 3, 2)]
    [InlineData(60, 5, 12)]
    public void TestarVisaoEntreDoisNumeros(double numero1, double numero2, double valorEsperado)
    {
        Assert.Equal(valorEsperado, _calc.Dividir(numero1, numero2));
    }

    [Fact]
    public void TestarSeDividirPorZeroRetornaUmaExcecao()
    {
        Assert.Throws<DivideByZeroException>(
            () => _calc.Dividir(3, 0)
        );
    }
}