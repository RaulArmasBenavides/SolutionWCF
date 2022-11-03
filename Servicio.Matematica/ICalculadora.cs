using System.ServiceModel;

namespace Servicio.Matematica
{
    [ServiceContract]
    public interface ICalculadora
    {
        #region Contratos
        //definir constratos

        [OperationContract]
        decimal Sumar(decimal x, decimal y);

        [OperationContract]
        decimal Restar(decimal x, decimal y);

        [OperationContract]
        decimal Multiplicar(decimal x, decimal y);

        [OperationContract]
        decimal Dividir(decimal x, decimal y);

        #endregion

    }
}
