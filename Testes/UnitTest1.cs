namespace Testes;

using Projeto;

public class UnitTest1
{
    public Calculadora ConstruirClasse()
    {
        Calculadora calc = new Calculadora("10/03/2024");

        return calc;
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TestSomar(int val1, int val2, int resultado)
    {
        Calculadora calc = ConstruirClasse();

        int resultadoCalculadora = calc.somar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void TestMutiplicar(int val1, int val2, int resultado)
    {
        Calculadora calc = ConstruirClasse();

        int resultadoCalculadora = calc.multiplicar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(5, 5, 1)]
    public void TestDividir(int val1, int val2, int resultado)
    {
        Calculadora calc = ConstruirClasse();

        int resultadoCalculadora = calc.dividir(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(6, 2, 4)]
    [InlineData(6, 5, 1)]
    public void TestSubtrair(int val1, int val2, int resultado)
    {
        Calculadora calc = ConstruirClasse();

        int resultadoCalculadora = calc.subtrair(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Calculadora calc = ConstruirClasse();

        Assert.Throws<DivideByZeroException>(
            () => calc.dividir(3, 0)
            );
    }

    [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = ConstruirClasse();

        calc.somar(1, 2);
        calc.somar(2, 8);
        calc.somar(3, 7);
        calc.somar(4, 1);

        var lista = calc.historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }


}