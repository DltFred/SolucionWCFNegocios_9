﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiciosWeb09.ReferenciaNegocios {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReferenciaNegocios.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/clientes", ReplyAction="http://tempuri.org/IService1/clientesResponse")]
        WCFNegocios_9.Cliente[] clientes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/clientes", ReplyAction="http://tempuri.org/IService1/clientesResponse")]
        System.Threading.Tasks.Task<WCFNegocios_9.Cliente[]> clientesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/paises", ReplyAction="http://tempuri.org/IService1/paisesResponse")]
        WCFNegocios_9.Pais[] paises();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/paises", ReplyAction="http://tempuri.org/IService1/paisesResponse")]
        System.Threading.Tasks.Task<WCFNegocios_9.Pais[]> paisesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Agregar", ReplyAction="http://tempuri.org/IService1/AgregarResponse")]
        string Agregar(WCFNegocios_9.Cliente reg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Agregar", ReplyAction="http://tempuri.org/IService1/AgregarResponse")]
        System.Threading.Tasks.Task<string> AgregarAsync(WCFNegocios_9.Cliente reg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Actualizar", ReplyAction="http://tempuri.org/IService1/ActualizarResponse")]
        string Actualizar(WCFNegocios_9.Cliente reg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Actualizar", ReplyAction="http://tempuri.org/IService1/ActualizarResponse")]
        System.Threading.Tasks.Task<string> ActualizarAsync(WCFNegocios_9.Cliente reg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Buscar", ReplyAction="http://tempuri.org/IService1/BuscarResponse")]
        WCFNegocios_9.Cliente Buscar(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Buscar", ReplyAction="http://tempuri.org/IService1/BuscarResponse")]
        System.Threading.Tasks.Task<WCFNegocios_9.Cliente> BuscarAsync(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ServiciosWeb09.ReferenciaNegocios.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ServiciosWeb09.ReferenciaNegocios.IService1>, ServiciosWeb09.ReferenciaNegocios.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCFNegocios_9.Cliente[] clientes() {
            return base.Channel.clientes();
        }
        
        public System.Threading.Tasks.Task<WCFNegocios_9.Cliente[]> clientesAsync() {
            return base.Channel.clientesAsync();
        }
        
        public WCFNegocios_9.Pais[] paises() {
            return base.Channel.paises();
        }
        
        public System.Threading.Tasks.Task<WCFNegocios_9.Pais[]> paisesAsync() {
            return base.Channel.paisesAsync();
        }
        
        public string Agregar(WCFNegocios_9.Cliente reg) {
            return base.Channel.Agregar(reg);
        }
        
        public System.Threading.Tasks.Task<string> AgregarAsync(WCFNegocios_9.Cliente reg) {
            return base.Channel.AgregarAsync(reg);
        }
        
        public string Actualizar(WCFNegocios_9.Cliente reg) {
            return base.Channel.Actualizar(reg);
        }
        
        public System.Threading.Tasks.Task<string> ActualizarAsync(WCFNegocios_9.Cliente reg) {
            return base.Channel.ActualizarAsync(reg);
        }
        
        public WCFNegocios_9.Cliente Buscar(string id) {
            return base.Channel.Buscar(id);
        }
        
        public System.Threading.Tasks.Task<WCFNegocios_9.Cliente> BuscarAsync(string id) {
            return base.Channel.BuscarAsync(id);
        }
    }
}
