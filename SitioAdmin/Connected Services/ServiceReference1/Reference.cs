﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitioAdmin.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UsuariosVM", Namespace="http://schemas.datacontract.org/2004/07/wcfMinIndustria.Model")]
    [System.SerializableAttribute()]
    public partial class UsuariosVM : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContrasenaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CorreoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DireccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefonoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contrasena {
            get {
                return this.ContrasenaField;
            }
            set {
                if ((object.ReferenceEquals(this.ContrasenaField, value) != true)) {
                    this.ContrasenaField = value;
                    this.RaisePropertyChanged("Contrasena");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Correo {
            get {
                return this.CorreoField;
            }
            set {
                if ((object.ReferenceEquals(this.CorreoField, value) != true)) {
                    this.CorreoField = value;
                    this.RaisePropertyChanged("Correo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Direccion {
            get {
                return this.DireccionField;
            }
            set {
                if ((object.ReferenceEquals(this.DireccionField, value) != true)) {
                    this.DireccionField = value;
                    this.RaisePropertyChanged("Direccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdUsuario {
            get {
                return this.IdUsuarioField;
            }
            set {
                if ((this.IdUsuarioField.Equals(value) != true)) {
                    this.IdUsuarioField = value;
                    this.RaisePropertyChanged("IdUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefono {
            get {
                return this.TelefonoField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefonoField, value) != true)) {
                    this.TelefonoField = value;
                    this.RaisePropertyChanged("Telefono");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BachesVM", Namespace="http://schemas.datacontract.org/2004/07/wcfMinIndustria.Model")]
    [System.SerializableAttribute()]
    public partial class BachesVM : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CalleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DistritoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FcreacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdBacheField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PosicionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrioridadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TamanoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsuarioField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Calle {
            get {
                return this.CalleField;
            }
            set {
                if ((object.ReferenceEquals(this.CalleField, value) != true)) {
                    this.CalleField = value;
                    this.RaisePropertyChanged("Calle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Distrito {
            get {
                return this.DistritoField;
            }
            set {
                if ((object.ReferenceEquals(this.DistritoField, value) != true)) {
                    this.DistritoField = value;
                    this.RaisePropertyChanged("Distrito");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fcreacion {
            get {
                return this.FcreacionField;
            }
            set {
                if ((object.ReferenceEquals(this.FcreacionField, value) != true)) {
                    this.FcreacionField = value;
                    this.RaisePropertyChanged("Fcreacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdBache {
            get {
                return this.IdBacheField;
            }
            set {
                if ((this.IdBacheField.Equals(value) != true)) {
                    this.IdBacheField = value;
                    this.RaisePropertyChanged("IdBache");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Posicion {
            get {
                return this.PosicionField;
            }
            set {
                if ((object.ReferenceEquals(this.PosicionField, value) != true)) {
                    this.PosicionField = value;
                    this.RaisePropertyChanged("Posicion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Prioridad {
            get {
                return this.PrioridadField;
            }
            set {
                if ((object.ReferenceEquals(this.PrioridadField, value) != true)) {
                    this.PrioridadField = value;
                    this.RaisePropertyChanged("Prioridad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tamano {
            get {
                return this.TamanoField;
            }
            set {
                if ((object.ReferenceEquals(this.TamanoField, value) != true)) {
                    this.TamanoField = value;
                    this.RaisePropertyChanged("Tamano");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Usuario {
            get {
                return this.UsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.UsuarioField, value) != true)) {
                    this.UsuarioField = value;
                    this.RaisePropertyChanged("Usuario");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Respuesta", Namespace="http://schemas.datacontract.org/2004/07/wcfMinIndustria")]
    [System.SerializableAttribute()]
    public partial class Respuesta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdRespuestaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdSolicitudField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensajeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool RespuestaOkField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdRespuesta {
            get {
                return this.IdRespuestaField;
            }
            set {
                if ((this.IdRespuestaField.Equals(value) != true)) {
                    this.IdRespuestaField = value;
                    this.RaisePropertyChanged("IdRespuesta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdSolicitud {
            get {
                return this.IdSolicitudField;
            }
            set {
                if ((this.IdSolicitudField.Equals(value) != true)) {
                    this.IdSolicitudField = value;
                    this.RaisePropertyChanged("IdSolicitud");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mensaje {
            get {
                return this.MensajeField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajeField, value) != true)) {
                    this.MensajeField = value;
                    this.RaisePropertyChanged("Mensaje");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool RespuestaOk {
            get {
                return this.RespuestaOkField;
            }
            set {
                if ((this.RespuestaOkField.Equals(value) != true)) {
                    this.RespuestaOkField = value;
                    this.RaisePropertyChanged("RespuestaOk");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DanoVM", Namespace="http://schemas.datacontract.org/2004/07/wcfMinIndustria.Model")]
    [System.SerializableAttribute()]
    public partial class DanoVM : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double CostoReparacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FcreacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdBacheField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdReporteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoDanoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double CostoReparacion {
            get {
                return this.CostoReparacionField;
            }
            set {
                if ((this.CostoReparacionField.Equals(value) != true)) {
                    this.CostoReparacionField = value;
                    this.RaisePropertyChanged("CostoReparacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fcreacion {
            get {
                return this.FcreacionField;
            }
            set {
                if ((object.ReferenceEquals(this.FcreacionField, value) != true)) {
                    this.FcreacionField = value;
                    this.RaisePropertyChanged("Fcreacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdBache {
            get {
                return this.IdBacheField;
            }
            set {
                if ((this.IdBacheField.Equals(value) != true)) {
                    this.IdBacheField = value;
                    this.RaisePropertyChanged("IdBache");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdReporte {
            get {
                return this.IdReporteField;
            }
            set {
                if ((this.IdReporteField.Equals(value) != true)) {
                    this.IdReporteField = value;
                    this.RaisePropertyChanged("IdReporte");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdUsuario {
            get {
                return this.IdUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.IdUsuarioField, value) != true)) {
                    this.IdUsuarioField = value;
                    this.RaisePropertyChanged("IdUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoDano {
            get {
                return this.TipoDanoField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoDanoField, value) != true)) {
                    this.TipoDanoField = value;
                    this.RaisePropertyChanged("TipoDano");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IwcfExtService")]
    public interface IwcfExtService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfExtService/Login", ReplyAction="http://tempuri.org/IwcfExtService/LoginResponse")]
        SitioAdmin.ServiceReference1.UsuariosVM Login(string strUsuario, string strPass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfExtService/Login", ReplyAction="http://tempuri.org/IwcfExtService/LoginResponse")]
        System.Threading.Tasks.Task<SitioAdmin.ServiceReference1.UsuariosVM> LoginAsync(string strUsuario, string strPass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfExtService/Listado", ReplyAction="http://tempuri.org/IwcfExtService/ListadoResponse")]
        SitioAdmin.ServiceReference1.BachesVM[] Listado();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfExtService/Listado", ReplyAction="http://tempuri.org/IwcfExtService/ListadoResponse")]
        System.Threading.Tasks.Task<SitioAdmin.ServiceReference1.BachesVM[]> ListadoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfExtService/RegistroReporteBache", ReplyAction="http://tempuri.org/IwcfExtService/RegistroReporteBacheResponse")]
        SitioAdmin.ServiceReference1.Respuesta RegistroReporteBache(SitioAdmin.ServiceReference1.BachesVM objRegistroBaches);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfExtService/RegistroReporteBache", ReplyAction="http://tempuri.org/IwcfExtService/RegistroReporteBacheResponse")]
        System.Threading.Tasks.Task<SitioAdmin.ServiceReference1.Respuesta> RegistroReporteBacheAsync(SitioAdmin.ServiceReference1.BachesVM objRegistroBaches);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfExtService/RegistroReporteDano", ReplyAction="http://tempuri.org/IwcfExtService/RegistroReporteDanoResponse")]
        SitioAdmin.ServiceReference1.Respuesta RegistroReporteDano(SitioAdmin.ServiceReference1.DanoVM objRegistroDano);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfExtService/RegistroReporteDano", ReplyAction="http://tempuri.org/IwcfExtService/RegistroReporteDanoResponse")]
        System.Threading.Tasks.Task<SitioAdmin.ServiceReference1.Respuesta> RegistroReporteDanoAsync(SitioAdmin.ServiceReference1.DanoVM objRegistroDano);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfExtService/ListadoDano", ReplyAction="http://tempuri.org/IwcfExtService/ListadoDanoResponse")]
        SitioAdmin.ServiceReference1.DanoVM[] ListadoDano();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfExtService/ListadoDano", ReplyAction="http://tempuri.org/IwcfExtService/ListadoDanoResponse")]
        System.Threading.Tasks.Task<SitioAdmin.ServiceReference1.DanoVM[]> ListadoDanoAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IwcfExtServiceChannel : SitioAdmin.ServiceReference1.IwcfExtService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IwcfExtServiceClient : System.ServiceModel.ClientBase<SitioAdmin.ServiceReference1.IwcfExtService>, SitioAdmin.ServiceReference1.IwcfExtService {
        
        public IwcfExtServiceClient() {
        }
        
        public IwcfExtServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IwcfExtServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IwcfExtServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IwcfExtServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SitioAdmin.ServiceReference1.UsuariosVM Login(string strUsuario, string strPass) {
            return base.Channel.Login(strUsuario, strPass);
        }
        
        public System.Threading.Tasks.Task<SitioAdmin.ServiceReference1.UsuariosVM> LoginAsync(string strUsuario, string strPass) {
            return base.Channel.LoginAsync(strUsuario, strPass);
        }
        
        public SitioAdmin.ServiceReference1.BachesVM[] Listado() {
            return base.Channel.Listado();
        }
        
        public System.Threading.Tasks.Task<SitioAdmin.ServiceReference1.BachesVM[]> ListadoAsync() {
            return base.Channel.ListadoAsync();
        }
        
        public SitioAdmin.ServiceReference1.Respuesta RegistroReporteBache(SitioAdmin.ServiceReference1.BachesVM objRegistroBaches) {
            return base.Channel.RegistroReporteBache(objRegistroBaches);
        }
        
        public System.Threading.Tasks.Task<SitioAdmin.ServiceReference1.Respuesta> RegistroReporteBacheAsync(SitioAdmin.ServiceReference1.BachesVM objRegistroBaches) {
            return base.Channel.RegistroReporteBacheAsync(objRegistroBaches);
        }
        
        public SitioAdmin.ServiceReference1.Respuesta RegistroReporteDano(SitioAdmin.ServiceReference1.DanoVM objRegistroDano) {
            return base.Channel.RegistroReporteDano(objRegistroDano);
        }
        
        public System.Threading.Tasks.Task<SitioAdmin.ServiceReference1.Respuesta> RegistroReporteDanoAsync(SitioAdmin.ServiceReference1.DanoVM objRegistroDano) {
            return base.Channel.RegistroReporteDanoAsync(objRegistroDano);
        }
        
        public SitioAdmin.ServiceReference1.DanoVM[] ListadoDano() {
            return base.Channel.ListadoDano();
        }
        
        public System.Threading.Tasks.Task<SitioAdmin.ServiceReference1.DanoVM[]> ListadoDanoAsync() {
            return base.Channel.ListadoDanoAsync();
        }
    }
}