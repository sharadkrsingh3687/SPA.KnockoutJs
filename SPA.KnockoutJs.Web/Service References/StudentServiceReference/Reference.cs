﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPA.KnockoutJs.Web.StudentServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/SPA.KnockoutJs.Service.Models")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClassField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EnrollYearField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StudentIDField;
        
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
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Class {
            get {
                return this.ClassField;
            }
            set {
                if ((object.ReferenceEquals(this.ClassField, value) != true)) {
                    this.ClassField = value;
                    this.RaisePropertyChanged("Class");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EnrollYear {
            get {
                return this.EnrollYearField;
            }
            set {
                if ((object.ReferenceEquals(this.EnrollYearField, value) != true)) {
                    this.EnrollYearField = value;
                    this.RaisePropertyChanged("EnrollYear");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StudentID {
            get {
                return this.StudentIDField;
            }
            set {
                if ((this.StudentIDField.Equals(value) != true)) {
                    this.StudentIDField = value;
                    this.RaisePropertyChanged("StudentID");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StudentServiceReference.IStudentService")]
    public interface IStudentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/GetAllStudentDetail", ReplyAction="http://tempuri.org/IStudentService/GetAllStudentDetailResponse")]
        System.Collections.Generic.List<SPA.KnockoutJs.Web.StudentServiceReference.Student> GetAllStudentDetail();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/GetAllStudentDetail", ReplyAction="http://tempuri.org/IStudentService/GetAllStudentDetailResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<SPA.KnockoutJs.Web.StudentServiceReference.Student>> GetAllStudentDetailAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/GetStudentDetail", ReplyAction="http://tempuri.org/IStudentService/GetStudentDetailResponse")]
        SPA.KnockoutJs.Web.StudentServiceReference.Student GetStudentDetail(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/GetStudentDetail", ReplyAction="http://tempuri.org/IStudentService/GetStudentDetailResponse")]
        System.Threading.Tasks.Task<SPA.KnockoutJs.Web.StudentServiceReference.Student> GetStudentDetailAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/SaveStudentDetail", ReplyAction="http://tempuri.org/IStudentService/SaveStudentDetailResponse")]
        SPA.KnockoutJs.Web.StudentServiceReference.Student SaveStudentDetail(System.Nullable<int> id, SPA.KnockoutJs.Web.StudentServiceReference.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/SaveStudentDetail", ReplyAction="http://tempuri.org/IStudentService/SaveStudentDetailResponse")]
        System.Threading.Tasks.Task<SPA.KnockoutJs.Web.StudentServiceReference.Student> SaveStudentDetailAsync(System.Nullable<int> id, SPA.KnockoutJs.Web.StudentServiceReference.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/DeleteStudentDetail", ReplyAction="http://tempuri.org/IStudentService/DeleteStudentDetailResponse")]
        bool DeleteStudentDetail(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/DeleteStudentDetail", ReplyAction="http://tempuri.org/IStudentService/DeleteStudentDetailResponse")]
        System.Threading.Tasks.Task<bool> DeleteStudentDetailAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStudentServiceChannel : SPA.KnockoutJs.Web.StudentServiceReference.IStudentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StudentServiceClient : System.ServiceModel.ClientBase<SPA.KnockoutJs.Web.StudentServiceReference.IStudentService>, SPA.KnockoutJs.Web.StudentServiceReference.IStudentService {
        
        public StudentServiceClient() {
        }
        
        public StudentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StudentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<SPA.KnockoutJs.Web.StudentServiceReference.Student> GetAllStudentDetail() {
            return base.Channel.GetAllStudentDetail();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<SPA.KnockoutJs.Web.StudentServiceReference.Student>> GetAllStudentDetailAsync() {
            return base.Channel.GetAllStudentDetailAsync();
        }
        
        public SPA.KnockoutJs.Web.StudentServiceReference.Student GetStudentDetail(int id) {
            return base.Channel.GetStudentDetail(id);
        }
        
        public System.Threading.Tasks.Task<SPA.KnockoutJs.Web.StudentServiceReference.Student> GetStudentDetailAsync(int id) {
            return base.Channel.GetStudentDetailAsync(id);
        }
        
        public SPA.KnockoutJs.Web.StudentServiceReference.Student SaveStudentDetail(System.Nullable<int> id, SPA.KnockoutJs.Web.StudentServiceReference.Student student) {
            return base.Channel.SaveStudentDetail(id, student);
        }
        
        public System.Threading.Tasks.Task<SPA.KnockoutJs.Web.StudentServiceReference.Student> SaveStudentDetailAsync(System.Nullable<int> id, SPA.KnockoutJs.Web.StudentServiceReference.Student student) {
            return base.Channel.SaveStudentDetailAsync(id, student);
        }
        
        public bool DeleteStudentDetail(int id) {
            return base.Channel.DeleteStudentDetail(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteStudentDetailAsync(int id) {
            return base.Channel.DeleteStudentDetailAsync(id);
        }
    }
}