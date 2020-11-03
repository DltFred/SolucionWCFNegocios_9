using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFNegocios_9
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract] List<Cliente> clientes();
        [OperationContract] List<Pais> paises();
        [OperationContract] string Agregar(Cliente reg);
        [OperationContract] string Actualizar(Cliente reg);
        [OperationContract] Cliente Buscar(string id);
    }
    [DataContract]
    public class Cliente
    {
        [DataMember] public string idcliente { get; set; }
        [DataMember] public string nombrecia { get; set; }
        [DataMember] public string direccion { get; set; }
        [DataMember] public string idpais { get; set; }
        [DataMember] public string telefono { get; set; }

    }
    [DataContract]
    public class Pais
    {
        [DataMember] public string idpais { get; set; }
        [DataMember] public string nombrepais { get; set; }

    }
}
