﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackgroundServiceClient.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/BackgroundService")]
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService/GetDataUsingDataContractResponse")]
        BackgroundServiceClient.ServiceReference.CompositeType GetDataUsingDataContract(BackgroundServiceClient.ServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/StartProcess", ReplyAction="http://tempuri.org/IService/StartProcessResponse")]
        void StartProcess(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetTaskState", ReplyAction="http://tempuri.org/IService/GetTaskStateResponse")]
        string GetTaskState(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SaveFamilyMember", ReplyAction="http://tempuri.org/IService/SaveFamilyMemberResponse")]
        void SaveFamilyMember(System.Guid userId, System.Guid Person, System.Nullable<System.Guid> Family_Membership, System.Nullable<System.Guid> Disability, System.Guid Application_State, System.Nullable<System.Guid> DisabilityType, System.Nullable<decimal> Family_MemberKON, System.Nullable<System.Guid> DisablilityGroupe, System.Nullable<System.Guid> employment, string DeadInfoFamMem);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : BackgroundServiceClient.ServiceReference.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<BackgroundServiceClient.ServiceReference.IService>, BackgroundServiceClient.ServiceReference.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public BackgroundServiceClient.ServiceReference.CompositeType GetDataUsingDataContract(BackgroundServiceClient.ServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public void StartProcess(string name) {
            base.Channel.StartProcess(name);
        }
        
        public string GetTaskState(string name) {
            return base.Channel.GetTaskState(name);
        }
        
        public void SaveFamilyMember(System.Guid userId, System.Guid Person, System.Nullable<System.Guid> Family_Membership, System.Nullable<System.Guid> Disability, System.Guid Application_State, System.Nullable<System.Guid> DisabilityType, System.Nullable<decimal> Family_MemberKON, System.Nullable<System.Guid> DisablilityGroupe, System.Nullable<System.Guid> employment, string DeadInfoFamMem) {
            base.Channel.SaveFamilyMember(userId, Person, Family_Membership, Disability, Application_State, DisabilityType, Family_MemberKON, DisablilityGroupe, employment, DeadInfoFamMem);
        }
    }
}
