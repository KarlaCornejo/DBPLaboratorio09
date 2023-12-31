﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AplicacionWebParaDBP.ServiciosLaboratorio {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiciosLaboratorio.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getCiudades", ReplyAction="http://tempuri.org/IService1/getCiudadesResponse")]
        string[] getCiudades();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getCiudades", ReplyAction="http://tempuri.org/IService1/getCiudadesResponse")]
        System.Threading.Tasks.Task<string[]> getCiudadesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GuardarInformacion", ReplyAction="http://tempuri.org/IService1/GuardarInformacionResponse")]
        void GuardarInformacion(string nombre, string apellidos, string sexo, string correo, string direccion, string ciudad, string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GuardarInformacion", ReplyAction="http://tempuri.org/IService1/GuardarInformacionResponse")]
        System.Threading.Tasks.Task GuardarInformacionAsync(string nombre, string apellidos, string sexo, string correo, string direccion, string ciudad, string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCiudades_SQL", ReplyAction="http://tempuri.org/IService1/GetCiudades_SQLResponse")]
        string[] GetCiudades_SQL();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCiudades_SQL", ReplyAction="http://tempuri.org/IService1/GetCiudades_SQLResponse")]
        System.Threading.Tasks.Task<string[]> GetCiudades_SQLAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GuardarInformacionSimpleSQL", ReplyAction="http://tempuri.org/IService1/GuardarInformacionSimpleSQLResponse")]
        bool GuardarInformacionSimpleSQL(string nombre, string apellidos, string sexo, string correo, string direccion, int codeCiudad, string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GuardarInformacionSimpleSQL", ReplyAction="http://tempuri.org/IService1/GuardarInformacionSimpleSQLResponse")]
        System.Threading.Tasks.Task<bool> GuardarInformacionSimpleSQLAsync(string nombre, string apellidos, string sexo, string correo, string direccion, int codeCiudad, string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GuardarInformacionVerificandoSQL", ReplyAction="http://tempuri.org/IService1/GuardarInformacionVerificandoSQLResponse")]
        bool GuardarInformacionVerificandoSQL(string nombre, string apellidos, string sexo, string email, string direccion, int codeCiudad, string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GuardarInformacionVerificandoSQL", ReplyAction="http://tempuri.org/IService1/GuardarInformacionVerificandoSQLResponse")]
        System.Threading.Tasks.Task<bool> GuardarInformacionVerificandoSQLAsync(string nombre, string apellidos, string sexo, string email, string direccion, int codeCiudad, string descripcion);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : AplicacionWebParaDBP.ServiciosLaboratorio.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<AplicacionWebParaDBP.ServiciosLaboratorio.IService1>, AplicacionWebParaDBP.ServiciosLaboratorio.IService1 {
        
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
        
        public string[] getCiudades() {
            return base.Channel.getCiudades();
        }
        
        public System.Threading.Tasks.Task<string[]> getCiudadesAsync() {
            return base.Channel.getCiudadesAsync();
        }
        
        public void GuardarInformacion(string nombre, string apellidos, string sexo, string correo, string direccion, string ciudad, string descripcion) {
            base.Channel.GuardarInformacion(nombre, apellidos, sexo, correo, direccion, ciudad, descripcion);
        }
        
        public System.Threading.Tasks.Task GuardarInformacionAsync(string nombre, string apellidos, string sexo, string correo, string direccion, string ciudad, string descripcion) {
            return base.Channel.GuardarInformacionAsync(nombre, apellidos, sexo, correo, direccion, ciudad, descripcion);
        }
        
        public string[] GetCiudades_SQL() {
            return base.Channel.GetCiudades_SQL();
        }
        
        public System.Threading.Tasks.Task<string[]> GetCiudades_SQLAsync() {
            return base.Channel.GetCiudades_SQLAsync();
        }
        
        public bool GuardarInformacionSimpleSQL(string nombre, string apellidos, string sexo, string correo, string direccion, int codeCiudad, string descripcion) {
            return base.Channel.GuardarInformacionSimpleSQL(nombre, apellidos, sexo, correo, direccion, codeCiudad, descripcion);
        }
        
        public System.Threading.Tasks.Task<bool> GuardarInformacionSimpleSQLAsync(string nombre, string apellidos, string sexo, string correo, string direccion, int codeCiudad, string descripcion) {
            return base.Channel.GuardarInformacionSimpleSQLAsync(nombre, apellidos, sexo, correo, direccion, codeCiudad, descripcion);
        }
        
        public bool GuardarInformacionVerificandoSQL(string nombre, string apellidos, string sexo, string email, string direccion, int codeCiudad, string descripcion) {
            return base.Channel.GuardarInformacionVerificandoSQL(nombre, apellidos, sexo, email, direccion, codeCiudad, descripcion);
        }
        
        public System.Threading.Tasks.Task<bool> GuardarInformacionVerificandoSQLAsync(string nombre, string apellidos, string sexo, string email, string direccion, int codeCiudad, string descripcion) {
            return base.Channel.GuardarInformacionVerificandoSQLAsync(nombre, apellidos, sexo, email, direccion, codeCiudad, descripcion);
        }
    }
}
