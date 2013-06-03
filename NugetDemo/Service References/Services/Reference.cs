﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NugetDemo.Services {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/TestService", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Person : System.Data.Objects.DataClasses.EntityObject, System.Runtime.Serialization.IExtensibleDataObject {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AdditionalContactInfoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BusinessEntityIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private NugetDemo.Services.Customer[] CustomersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DemographicsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmailPromotionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MiddleNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ModifiedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool NameStyleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PersonTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SuffixField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid rowguidField;
        
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
        public string AdditionalContactInfo {
            get {
                return this.AdditionalContactInfoField;
            }
            set {
                this.AdditionalContactInfoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BusinessEntityID {
            get {
                return this.BusinessEntityIDField;
            }
            set {
                this.BusinessEntityIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public NugetDemo.Services.Customer[] Customers {
            get {
                return this.CustomersField;
            }
            set {
                this.CustomersField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Demographics {
            get {
                return this.DemographicsField;
            }
            set {
                this.DemographicsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EmailPromotion {
            get {
                return this.EmailPromotionField;
            }
            set {
                this.EmailPromotionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                this.FirstNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                this.LastNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MiddleName {
            get {
                return this.MiddleNameField;
            }
            set {
                this.MiddleNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ModifiedDate {
            get {
                return this.ModifiedDateField;
            }
            set {
                this.ModifiedDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool NameStyle {
            get {
                return this.NameStyleField;
            }
            set {
                this.NameStyleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PersonType {
            get {
                return this.PersonTypeField;
            }
            set {
                this.PersonTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Suffix {
            get {
                return this.SuffixField;
            }
            set {
                this.SuffixField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                this.TitleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid rowguid {
            get {
                return this.rowguidField;
            }
            set {
                this.rowguidField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/TestService", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Customer : System.Data.Objects.DataClasses.EntityObject, System.Runtime.Serialization.IExtensibleDataObject {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AccountNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ModifiedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private NugetDemo.Services.Person PersonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> PersonIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Data.Objects.DataClasses.EntityReference<NugetDemo.Services.Person> PersonReferenceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> StoreIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> TerritoryIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid rowguidField;
        
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
        public string AccountNumber {
            get {
                return this.AccountNumberField;
            }
            set {
                this.AccountNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerID {
            get {
                return this.CustomerIDField;
            }
            set {
                this.CustomerIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ModifiedDate {
            get {
                return this.ModifiedDateField;
            }
            set {
                this.ModifiedDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public NugetDemo.Services.Person Person {
            get {
                return this.PersonField;
            }
            set {
                this.PersonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> PersonID {
            get {
                return this.PersonIDField;
            }
            set {
                this.PersonIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Data.Objects.DataClasses.EntityReference<NugetDemo.Services.Person> PersonReference {
            get {
                return this.PersonReferenceField;
            }
            set {
                this.PersonReferenceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> StoreID {
            get {
                return this.StoreIDField;
            }
            set {
                this.StoreIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> TerritoryID {
            get {
                return this.TerritoryIDField;
            }
            set {
                this.TerritoryIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid rowguid {
            get {
                return this.rowguidField;
            }
            set {
                this.rowguidField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Services.IPeopleService")]
    public interface IPeopleService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/FirstOneThousand", ReplyAction="http://tempuri.org/IPeopleService/FirstOneThousandResponse")]
        NugetDemo.Services.Person[] FirstOneThousand();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPeopleServiceChannel : NugetDemo.Services.IPeopleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PeopleServiceClient : System.ServiceModel.ClientBase<NugetDemo.Services.IPeopleService>, NugetDemo.Services.IPeopleService {
        
        public PeopleServiceClient() {
        }
        
        public PeopleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PeopleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PeopleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PeopleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public NugetDemo.Services.Person[] FirstOneThousand() {
            return base.Channel.FirstOneThousand();
        }
    }
}
