using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _validacoes;

        public ValidacoesStringTests()
        {
            _validacoes = new ValidacoesString();
        }

        [Fact]
        public void DeveContarCaracteresEmTesteERetornar5()
        {
            Assert.Equal(5,_validacoes.ContarCaracteres("Teste"));
        }
    }
}