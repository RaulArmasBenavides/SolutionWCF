using System;

namespace Servicio.Matematica
{
    public class Calculadora : ICalculadora
    {
        #region Metodos del Contrato
        public decimal Dividir(decimal x, decimal y)
        {
            return x / y;
        }

        public decimal Multiplicar(decimal x, decimal y)
        {
            return x * y;
        }

        public decimal Restar(decimal x, decimal y)
        {
            return x - y;
        }

        public decimal Sumar(decimal x, decimal y)
        {
            return x + y;
        }

        public double raiz(decimal x, decimal y)
        {
            return Math.Sqrt(Convert.ToDouble(x));
        }
        public double cuadrado(int x, int y)
        {
            return Math.Pow(Convert.ToDouble(x), Convert.ToDouble(y));
        }

        #endregion
    }

}
