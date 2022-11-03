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

        #endregion
    }

}
