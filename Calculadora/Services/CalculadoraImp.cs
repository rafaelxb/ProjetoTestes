namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int Somar(int num1, int num2)
        {
            return num1+num2;
        }

        public bool Par(int num)
        {
            return num % 2 == 0;
        }
    }
}