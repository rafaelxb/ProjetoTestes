using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _cal;
    public CalculadoraTests()
    {
        _cal = new CalculadoraImp();
    }
    [Fact]
    public void Somar5com5ERetornar10()
    {
        Assert.Equal(10,_cal.Somar(5,5));
    }

    [Fact]
    public void VerificarSe2EhPar()
    {
        Assert.True(_cal.Par(2));
    }

    [Theory]
    [InlineData(new int[]{2,4,6,8,10,12})]
    public void VerificarSeOsNumerosSaoPares(int[] nums)
    {
        Assert.All(nums,item => Assert.True(_cal.Par(item)));
    }
}