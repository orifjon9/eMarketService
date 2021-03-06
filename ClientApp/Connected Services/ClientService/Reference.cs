﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApp.ClientService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/MarketService")]
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClientService.IContextService")]
    public interface IContextService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContextService/GetData", ReplyAction="http://tempuri.org/IContextService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContextService/GetData", ReplyAction="http://tempuri.org/IContextService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContextService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IContextService/GetDataUsingDataContractResponse")]
        ClientApp.ClientService.CompositeType GetDataUsingDataContract(ClientApp.ClientService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContextService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IContextService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<ClientApp.ClientService.CompositeType> GetDataUsingDataContractAsync(ClientApp.ClientService.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IContextServiceChannel : ClientApp.ClientService.IContextService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ContextServiceClient : System.ServiceModel.ClientBase<ClientApp.ClientService.IContextService>, ClientApp.ClientService.IContextService {
        
        public ContextServiceClient() {
        }
        
        public ContextServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ContextServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContextServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContextServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public ClientApp.ClientService.CompositeType GetDataUsingDataContract(ClientApp.ClientService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<ClientApp.ClientService.CompositeType> GetDataUsingDataContractAsync(ClientApp.ClientService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
