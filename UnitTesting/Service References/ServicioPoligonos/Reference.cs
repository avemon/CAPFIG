﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitTesting.ServicioPoligonos {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/CalculadoraPoligonos.Especificaciones")]
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioPoligonos.ICalculadoraPoligonos")]
    public interface ICalculadoraPoligonos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadoraPoligonos/Ejecutar", ReplyAction="http://tempuri.org/ICalculadoraPoligonos/EjecutarResponse")]
        double Ejecutar(bool calcularArea, int numeroDeLados, double tamanoPorLado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadoraPoligonos/Ejecutar", ReplyAction="http://tempuri.org/ICalculadoraPoligonos/EjecutarResponse")]
        System.Threading.Tasks.Task<double> EjecutarAsync(bool calcularArea, int numeroDeLados, double tamanoPorLado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadoraPoligonos/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ICalculadoraPoligonos/GetDataUsingDataContractResponse")]
        UnitTesting.ServicioPoligonos.CompositeType GetDataUsingDataContract(UnitTesting.ServicioPoligonos.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadoraPoligonos/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ICalculadoraPoligonos/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<UnitTesting.ServicioPoligonos.CompositeType> GetDataUsingDataContractAsync(UnitTesting.ServicioPoligonos.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculadoraPoligonosChannel : UnitTesting.ServicioPoligonos.ICalculadoraPoligonos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculadoraPoligonosClient : System.ServiceModel.ClientBase<UnitTesting.ServicioPoligonos.ICalculadoraPoligonos>, UnitTesting.ServicioPoligonos.ICalculadoraPoligonos {
        
        public CalculadoraPoligonosClient() {
        }
        
        public CalculadoraPoligonosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculadoraPoligonosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculadoraPoligonosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculadoraPoligonosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Ejecutar(bool calcularArea, int numeroDeLados, double tamanoPorLado) {
            return base.Channel.Ejecutar(calcularArea, numeroDeLados, tamanoPorLado);
        }
        
        public System.Threading.Tasks.Task<double> EjecutarAsync(bool calcularArea, int numeroDeLados, double tamanoPorLado) {
            return base.Channel.EjecutarAsync(calcularArea, numeroDeLados, tamanoPorLado);
        }
        
        public UnitTesting.ServicioPoligonos.CompositeType GetDataUsingDataContract(UnitTesting.ServicioPoligonos.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<UnitTesting.ServicioPoligonos.CompositeType> GetDataUsingDataContractAsync(UnitTesting.ServicioPoligonos.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
