﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmsoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LetoRojstvaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PriimekField;
        
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
        public int Emso {
            get {
                return this.EmsoField;
            }
            set {
                if ((this.EmsoField.Equals(value) != true)) {
                    this.EmsoField = value;
                    this.RaisePropertyChanged("Emso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ime {
            get {
                return this.ImeField;
            }
            set {
                if ((object.ReferenceEquals(this.ImeField, value) != true)) {
                    this.ImeField = value;
                    this.RaisePropertyChanged("Ime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LetoRojstva {
            get {
                return this.LetoRojstvaField;
            }
            set {
                if ((this.LetoRojstvaField.Equals(value) != true)) {
                    this.LetoRojstvaField = value;
                    this.RaisePropertyChanged("LetoRojstva");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Priimek {
            get {
                return this.PriimekField;
            }
            set {
                if ((object.ReferenceEquals(this.PriimekField, value) != true)) {
                    this.PriimekField = value;
                    this.RaisePropertyChanged("Priimek");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Studentski_dom", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class Studentski_dom : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Leto_NastankaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Stevilka_DomaField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ime {
            get {
                return this.ImeField;
            }
            set {
                if ((object.ReferenceEquals(this.ImeField, value) != true)) {
                    this.ImeField = value;
                    this.RaisePropertyChanged("Ime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Leto_Nastanka {
            get {
                return this.Leto_NastankaField;
            }
            set {
                if ((this.Leto_NastankaField.Equals(value) != true)) {
                    this.Leto_NastankaField = value;
                    this.RaisePropertyChanged("Leto_Nastanka");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Stevilka_Doma {
            get {
                return this.Stevilka_DomaField;
            }
            set {
                if ((this.Stevilka_DomaField.Equals(value) != true)) {
                    this.Stevilka_DomaField = value;
                    this.RaisePropertyChanged("Stevilka_Doma");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        WpfApp1.ServiceReference1.CompositeType GetDataUsingDataContract(WpfApp1.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WpfApp1.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(WpfApp1.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/vpis", ReplyAction="http://tempuri.org/IService1/vpisResponse")]
        bool vpis(string uporabniško_ime, string geslo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/vpis", ReplyAction="http://tempuri.org/IService1/vpisResponse")]
        System.Threading.Tasks.Task<bool> vpisAsync(string uporabniško_ime, string geslo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PridobiVseStudente", ReplyAction="http://tempuri.org/IService1/PridobiVseStudenteResponse")]
        WpfApp1.ServiceReference1.Student[] PridobiVseStudente();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PridobiVseStudente", ReplyAction="http://tempuri.org/IService1/PridobiVseStudenteResponse")]
        System.Threading.Tasks.Task<WpfApp1.ServiceReference1.Student[]> PridobiVseStudenteAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PridobiVseDomove", ReplyAction="http://tempuri.org/IService1/PridobiVseDomoveResponse")]
        WpfApp1.ServiceReference1.Studentski_dom[] PridobiVseDomove();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PridobiVseDomove", ReplyAction="http://tempuri.org/IService1/PridobiVseDomoveResponse")]
        System.Threading.Tasks.Task<WpfApp1.ServiceReference1.Studentski_dom[]> PridobiVseDomoveAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VrniStudenta", ReplyAction="http://tempuri.org/IService1/VrniStudentaResponse")]
        WpfApp1.ServiceReference1.Student VrniStudenta(int emso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VrniStudenta", ReplyAction="http://tempuri.org/IService1/VrniStudentaResponse")]
        System.Threading.Tasks.Task<WpfApp1.ServiceReference1.Student> VrniStudentaAsync(int emso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IzpisNajstarejsega", ReplyAction="http://tempuri.org/IService1/IzpisNajstarejsegaResponse")]
        WpfApp1.ServiceReference1.Student IzpisNajstarejsega();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IzpisNajstarejsega", ReplyAction="http://tempuri.org/IService1/IzpisNajstarejsegaResponse")]
        System.Threading.Tasks.Task<WpfApp1.ServiceReference1.Student> IzpisNajstarejsegaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VrniDom", ReplyAction="http://tempuri.org/IService1/VrniDomResponse")]
        WpfApp1.ServiceReference1.Studentski_dom VrniDom();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VrniDom", ReplyAction="http://tempuri.org/IService1/VrniDomResponse")]
        System.Threading.Tasks.Task<WpfApp1.ServiceReference1.Studentski_dom> VrniDomAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IzpisPovprecneStarosti", ReplyAction="http://tempuri.org/IService1/IzpisPovprecneStarostiResponse")]
        double IzpisPovprecneStarosti();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IzpisPovprecneStarosti", ReplyAction="http://tempuri.org/IService1/IzpisPovprecneStarostiResponse")]
        System.Threading.Tasks.Task<double> IzpisPovprecneStarostiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DodajStudenta", ReplyAction="http://tempuri.org/IService1/DodajStudentaResponse")]
        bool DodajStudenta(int id, int emso, string ime, string priimek, int letoRojstva);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DodajStudenta", ReplyAction="http://tempuri.org/IService1/DodajStudentaResponse")]
        System.Threading.Tasks.Task<bool> DodajStudentaAsync(int id, int emso, string ime, string priimek, int letoRojstva);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DodajStudentskiDom", ReplyAction="http://tempuri.org/IService1/DodajStudentskiDomResponse")]
        bool DodajStudentskiDom(int stevilka_doma, string ime_doma, int leto_nastanka);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DodajStudentskiDom", ReplyAction="http://tempuri.org/IService1/DodajStudentskiDomResponse")]
        System.Threading.Tasks.Task<bool> DodajStudentskiDomAsync(int stevilka_doma, string ime_doma, int leto_nastanka);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DodajStudentaVDomu", ReplyAction="http://tempuri.org/IService1/DodajStudentaVDomuResponse")]
        bool DodajStudentaVDomu(WpfApp1.ServiceReference1.Student student, WpfApp1.ServiceReference1.Studentski_dom studentski_dom, int dolzina_bivanja, string tip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DodajStudentaVDomu", ReplyAction="http://tempuri.org/IService1/DodajStudentaVDomuResponse")]
        System.Threading.Tasks.Task<bool> DodajStudentaVDomuAsync(WpfApp1.ServiceReference1.Student student, WpfApp1.ServiceReference1.Studentski_dom studentski_dom, int dolzina_bivanja, string tip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/OdstraniStudenta", ReplyAction="http://tempuri.org/IService1/OdstraniStudentaResponse")]
        bool OdstraniStudenta(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/OdstraniStudenta", ReplyAction="http://tempuri.org/IService1/OdstraniStudentaResponse")]
        System.Threading.Tasks.Task<bool> OdstraniStudentaAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/OdstraniDom", ReplyAction="http://tempuri.org/IService1/OdstraniDomResponse")]
        bool OdstraniDom(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/OdstraniDom", ReplyAction="http://tempuri.org/IService1/OdstraniDomResponse")]
        System.Threading.Tasks.Task<bool> OdstraniDomAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/OdstraniStudentaizDomov", ReplyAction="http://tempuri.org/IService1/OdstraniStudentaizDomovResponse")]
        bool OdstraniStudentaizDomov(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/OdstraniStudentaizDomov", ReplyAction="http://tempuri.org/IService1/OdstraniStudentaizDomovResponse")]
        System.Threading.Tasks.Task<bool> OdstraniStudentaizDomovAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/OdstraniDomIzStudentVDomu", ReplyAction="http://tempuri.org/IService1/OdstraniDomIzStudentVDomuResponse")]
        bool OdstraniDomIzStudentVDomu(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/OdstraniDomIzStudentVDomu", ReplyAction="http://tempuri.org/IService1/OdstraniDomIzStudentVDomuResponse")]
        System.Threading.Tasks.Task<bool> OdstraniDomIzStudentVDomuAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UrediStudenta", ReplyAction="http://tempuri.org/IService1/UrediStudentaResponse")]
        bool UrediStudenta(int idUporabnika, int emso, string Ime, string Priimek, int leto_rojstva);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UrediStudenta", ReplyAction="http://tempuri.org/IService1/UrediStudentaResponse")]
        System.Threading.Tasks.Task<bool> UrediStudentaAsync(int idUporabnika, int emso, string Ime, string Priimek, int leto_rojstva);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UrediDom", ReplyAction="http://tempuri.org/IService1/UrediDomResponse")]
        bool UrediDom(int Id, string ime, int stevilkadoma);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UrediDom", ReplyAction="http://tempuri.org/IService1/UrediDomResponse")]
        System.Threading.Tasks.Task<bool> UrediDomAsync(int Id, string ime, int stevilkadoma);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WpfApp1.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WpfApp1.ServiceReference1.IService1>, WpfApp1.ServiceReference1.IService1 {
        
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
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public WpfApp1.ServiceReference1.CompositeType GetDataUsingDataContract(WpfApp1.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WpfApp1.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(WpfApp1.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public bool vpis(string uporabniško_ime, string geslo) {
            return base.Channel.vpis(uporabniško_ime, geslo);
        }
        
        public System.Threading.Tasks.Task<bool> vpisAsync(string uporabniško_ime, string geslo) {
            return base.Channel.vpisAsync(uporabniško_ime, geslo);
        }
        
        public WpfApp1.ServiceReference1.Student[] PridobiVseStudente() {
            return base.Channel.PridobiVseStudente();
        }
        
        public System.Threading.Tasks.Task<WpfApp1.ServiceReference1.Student[]> PridobiVseStudenteAsync() {
            return base.Channel.PridobiVseStudenteAsync();
        }
        
        public WpfApp1.ServiceReference1.Studentski_dom[] PridobiVseDomove() {
            return base.Channel.PridobiVseDomove();
        }
        
        public System.Threading.Tasks.Task<WpfApp1.ServiceReference1.Studentski_dom[]> PridobiVseDomoveAsync() {
            return base.Channel.PridobiVseDomoveAsync();
        }
        
        public WpfApp1.ServiceReference1.Student VrniStudenta(int emso) {
            return base.Channel.VrniStudenta(emso);
        }
        
        public System.Threading.Tasks.Task<WpfApp1.ServiceReference1.Student> VrniStudentaAsync(int emso) {
            return base.Channel.VrniStudentaAsync(emso);
        }
        
        public WpfApp1.ServiceReference1.Student IzpisNajstarejsega() {
            return base.Channel.IzpisNajstarejsega();
        }
        
        public System.Threading.Tasks.Task<WpfApp1.ServiceReference1.Student> IzpisNajstarejsegaAsync() {
            return base.Channel.IzpisNajstarejsegaAsync();
        }
        
        public WpfApp1.ServiceReference1.Studentski_dom VrniDom() {
            return base.Channel.VrniDom();
        }
        
        public System.Threading.Tasks.Task<WpfApp1.ServiceReference1.Studentski_dom> VrniDomAsync() {
            return base.Channel.VrniDomAsync();
        }
        
        public double IzpisPovprecneStarosti() {
            return base.Channel.IzpisPovprecneStarosti();
        }
        
        public System.Threading.Tasks.Task<double> IzpisPovprecneStarostiAsync() {
            return base.Channel.IzpisPovprecneStarostiAsync();
        }
        
        public bool DodajStudenta(int id, int emso, string ime, string priimek, int letoRojstva) {
            return base.Channel.DodajStudenta(id, emso, ime, priimek, letoRojstva);
        }
        
        public System.Threading.Tasks.Task<bool> DodajStudentaAsync(int id, int emso, string ime, string priimek, int letoRojstva) {
            return base.Channel.DodajStudentaAsync(id, emso, ime, priimek, letoRojstva);
        }
        
        public bool DodajStudentskiDom(int stevilka_doma, string ime_doma, int leto_nastanka) {
            return base.Channel.DodajStudentskiDom(stevilka_doma, ime_doma, leto_nastanka);
        }
        
        public System.Threading.Tasks.Task<bool> DodajStudentskiDomAsync(int stevilka_doma, string ime_doma, int leto_nastanka) {
            return base.Channel.DodajStudentskiDomAsync(stevilka_doma, ime_doma, leto_nastanka);
        }
        
        public bool DodajStudentaVDomu(WpfApp1.ServiceReference1.Student student, WpfApp1.ServiceReference1.Studentski_dom studentski_dom, int dolzina_bivanja, string tip) {
            return base.Channel.DodajStudentaVDomu(student, studentski_dom, dolzina_bivanja, tip);
        }
        
        public System.Threading.Tasks.Task<bool> DodajStudentaVDomuAsync(WpfApp1.ServiceReference1.Student student, WpfApp1.ServiceReference1.Studentski_dom studentski_dom, int dolzina_bivanja, string tip) {
            return base.Channel.DodajStudentaVDomuAsync(student, studentski_dom, dolzina_bivanja, tip);
        }
        
        public bool OdstraniStudenta(int id) {
            return base.Channel.OdstraniStudenta(id);
        }
        
        public System.Threading.Tasks.Task<bool> OdstraniStudentaAsync(int id) {
            return base.Channel.OdstraniStudentaAsync(id);
        }
        
        public bool OdstraniDom(int id) {
            return base.Channel.OdstraniDom(id);
        }
        
        public System.Threading.Tasks.Task<bool> OdstraniDomAsync(int id) {
            return base.Channel.OdstraniDomAsync(id);
        }
        
        public bool OdstraniStudentaizDomov(int id) {
            return base.Channel.OdstraniStudentaizDomov(id);
        }
        
        public System.Threading.Tasks.Task<bool> OdstraniStudentaizDomovAsync(int id) {
            return base.Channel.OdstraniStudentaizDomovAsync(id);
        }
        
        public bool OdstraniDomIzStudentVDomu(int id) {
            return base.Channel.OdstraniDomIzStudentVDomu(id);
        }
        
        public System.Threading.Tasks.Task<bool> OdstraniDomIzStudentVDomuAsync(int id) {
            return base.Channel.OdstraniDomIzStudentVDomuAsync(id);
        }
        
        public bool UrediStudenta(int idUporabnika, int emso, string Ime, string Priimek, int leto_rojstva) {
            return base.Channel.UrediStudenta(idUporabnika, emso, Ime, Priimek, leto_rojstva);
        }
        
        public System.Threading.Tasks.Task<bool> UrediStudentaAsync(int idUporabnika, int emso, string Ime, string Priimek, int leto_rojstva) {
            return base.Channel.UrediStudentaAsync(idUporabnika, emso, Ime, Priimek, leto_rojstva);
        }
        
        public bool UrediDom(int Id, string ime, int stevilkadoma) {
            return base.Channel.UrediDom(Id, ime, stevilkadoma);
        }
        
        public System.Threading.Tasks.Task<bool> UrediDomAsync(int Id, string ime, int stevilkadoma) {
            return base.Channel.UrediDomAsync(Id, ime, stevilkadoma);
        }
    }
}
