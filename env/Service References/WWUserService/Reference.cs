﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace env.WWUserService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResponseModel", Namespace="http://schemas.datacontract.org/2004/07/StarEnergyService.Helper")]
    [System.SerializableAttribute()]
    public partial class ResponseModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string messageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private env.WWUserService.UserModel resultField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private env.WWUserService.ListUserModel resultsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool statusField;
        
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
        public string message {
            get {
                return this.messageField;
            }
            set {
                if ((object.ReferenceEquals(this.messageField, value) != true)) {
                    this.messageField = value;
                    this.RaisePropertyChanged("message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public env.WWUserService.UserModel result {
            get {
                return this.resultField;
            }
            set {
                if ((object.ReferenceEquals(this.resultField, value) != true)) {
                    this.resultField = value;
                    this.RaisePropertyChanged("result");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public env.WWUserService.ListUserModel results {
            get {
                return this.resultsField;
            }
            set {
                if ((object.ReferenceEquals(this.resultsField, value) != true)) {
                    this.resultsField = value;
                    this.RaisePropertyChanged("results");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool status {
            get {
                return this.statusField;
            }
            set {
                if ((this.statusField.Equals(value) != true)) {
                    this.statusField = value;
                    this.RaisePropertyChanged("status");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UserModel", Namespace="http://schemas.datacontract.org/2004/07/StarEnergyService")]
    [System.SerializableAttribute()]
    public partial class UserModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string alpha_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<byte> approval_levelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<byte> delagateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string departmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> dept_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> employee_bossField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> employee_delegateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> employee_deptField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string employee_noField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string positionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string signatureField;
        
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
        public string alpha_name {
            get {
                return this.alpha_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.alpha_nameField, value) != true)) {
                    this.alpha_nameField = value;
                    this.RaisePropertyChanged("alpha_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<byte> approval_level {
            get {
                return this.approval_levelField;
            }
            set {
                if ((this.approval_levelField.Equals(value) != true)) {
                    this.approval_levelField = value;
                    this.RaisePropertyChanged("approval_level");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<byte> delagate {
            get {
                return this.delagateField;
            }
            set {
                if ((this.delagateField.Equals(value) != true)) {
                    this.delagateField = value;
                    this.RaisePropertyChanged("delagate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string department {
            get {
                return this.departmentField;
            }
            set {
                if ((object.ReferenceEquals(this.departmentField, value) != true)) {
                    this.departmentField = value;
                    this.RaisePropertyChanged("department");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> dept_id {
            get {
                return this.dept_idField;
            }
            set {
                if ((this.dept_idField.Equals(value) != true)) {
                    this.dept_idField = value;
                    this.RaisePropertyChanged("dept_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> employee_boss {
            get {
                return this.employee_bossField;
            }
            set {
                if ((this.employee_bossField.Equals(value) != true)) {
                    this.employee_bossField = value;
                    this.RaisePropertyChanged("employee_boss");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> employee_delegate {
            get {
                return this.employee_delegateField;
            }
            set {
                if ((this.employee_delegateField.Equals(value) != true)) {
                    this.employee_delegateField = value;
                    this.RaisePropertyChanged("employee_delegate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> employee_dept {
            get {
                return this.employee_deptField;
            }
            set {
                if ((this.employee_deptField.Equals(value) != true)) {
                    this.employee_deptField = value;
                    this.RaisePropertyChanged("employee_dept");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string employee_no {
            get {
                return this.employee_noField;
            }
            set {
                if ((object.ReferenceEquals(this.employee_noField, value) != true)) {
                    this.employee_noField = value;
                    this.RaisePropertyChanged("employee_no");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string position {
            get {
                return this.positionField;
            }
            set {
                if ((object.ReferenceEquals(this.positionField, value) != true)) {
                    this.positionField = value;
                    this.RaisePropertyChanged("position");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string signature {
            get {
                return this.signatureField;
            }
            set {
                if ((object.ReferenceEquals(this.signatureField, value) != true)) {
                    this.signatureField = value;
                    this.RaisePropertyChanged("signature");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ListUserModel", Namespace="http://schemas.datacontract.org/2004/07/StarEnergyService.Helper")]
    [System.SerializableAttribute()]
    public partial class ListUserModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int countField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private env.WWUserService.UserModel[] listUserModelField;
        
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
        public int count {
            get {
                return this.countField;
            }
            set {
                if ((this.countField.Equals(value) != true)) {
                    this.countField = value;
                    this.RaisePropertyChanged("count");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public env.WWUserService.UserModel[] listUserModel {
            get {
                return this.listUserModelField;
            }
            set {
                if ((object.ReferenceEquals(this.listUserModelField, value) != true)) {
                    this.listUserModelField = value;
                    this.RaisePropertyChanged("listUserModel");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WWUserService.IUserService")]
    public interface IUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/listUser", ReplyAction="http://tempuri.org/IUserService/listUserResponse")]
        env.WWUserService.ResponseModel listUser(string token, int id, int count, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/listUser", ReplyAction="http://tempuri.org/IUserService/listUserResponse")]
        System.Threading.Tasks.Task<env.WWUserService.ResponseModel> listUserAsync(string token, int id, int count, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/getUser", ReplyAction="http://tempuri.org/IUserService/getUserResponse")]
        env.WWUserService.ResponseModel getUser(string token, int idLogin, int idUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/getUser", ReplyAction="http://tempuri.org/IUserService/getUserResponse")]
        System.Threading.Tasks.Task<env.WWUserService.ResponseModel> getUserAsync(string token, int idLogin, int idUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/getSubordinat", ReplyAction="http://tempuri.org/IUserService/getSubordinatResponse")]
        env.WWUserService.ResponseModel getSubordinat(string token, int idLogin, int idUser, bool withSuperintendent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/getSubordinat", ReplyAction="http://tempuri.org/IUserService/getSubordinatResponse")]
        System.Threading.Tasks.Task<env.WWUserService.ResponseModel> getSubordinatAsync(string token, int idLogin, int idUser, bool withSuperintendent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/sendEmail", ReplyAction="http://tempuri.org/IUserService/sendEmailResponse")]
        env.WWUserService.ResponseModel sendEmail(string token, int idLogin, string[] email, string content, string subject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/sendEmail", ReplyAction="http://tempuri.org/IUserService/sendEmailResponse")]
        System.Threading.Tasks.Task<env.WWUserService.ResponseModel> sendEmailAsync(string token, int idLogin, string[] email, string content, string subject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/resendEmail", ReplyAction="http://tempuri.org/IUserService/resendEmailResponse")]
        void resendEmail(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/resendEmail", ReplyAction="http://tempuri.org/IUserService/resendEmailResponse")]
        System.Threading.Tasks.Task resendEmailAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/getSuperintendent", ReplyAction="http://tempuri.org/IUserService/getSuperintendentResponse")]
        env.WWUserService.ResponseModel getSuperintendent(string token, int idLogin, int idUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/getSuperintendent", ReplyAction="http://tempuri.org/IUserService/getSuperintendentResponse")]
        System.Threading.Tasks.Task<env.WWUserService.ResponseModel> getSuperintendentAsync(string token, int idLogin, int idUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/login", ReplyAction="http://tempuri.org/IUserService/loginResponse")]
        env.WWUserService.ResponseModel login(string username, string encodedPassword, System.Nullable<int> role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/login", ReplyAction="http://tempuri.org/IUserService/loginResponse")]
        System.Threading.Tasks.Task<env.WWUserService.ResponseModel> loginAsync(string username, string encodedPassword, System.Nullable<int> role);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServiceChannel : env.WWUserService.IUserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<env.WWUserService.IUserService>, env.WWUserService.IUserService {
        
        public UserServiceClient() {
        }
        
        public UserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public env.WWUserService.ResponseModel listUser(string token, int id, int count, int offset) {
            return base.Channel.listUser(token, id, count, offset);
        }
        
        public System.Threading.Tasks.Task<env.WWUserService.ResponseModel> listUserAsync(string token, int id, int count, int offset) {
            return base.Channel.listUserAsync(token, id, count, offset);
        }
        
        public env.WWUserService.ResponseModel getUser(string token, int idLogin, int idUser) {
            return base.Channel.getUser(token, idLogin, idUser);
        }
        
        public System.Threading.Tasks.Task<env.WWUserService.ResponseModel> getUserAsync(string token, int idLogin, int idUser) {
            return base.Channel.getUserAsync(token, idLogin, idUser);
        }
        
        public env.WWUserService.ResponseModel getSubordinat(string token, int idLogin, int idUser, bool withSuperintendent) {
            return base.Channel.getSubordinat(token, idLogin, idUser, withSuperintendent);
        }
        
        public System.Threading.Tasks.Task<env.WWUserService.ResponseModel> getSubordinatAsync(string token, int idLogin, int idUser, bool withSuperintendent) {
            return base.Channel.getSubordinatAsync(token, idLogin, idUser, withSuperintendent);
        }
        
        public env.WWUserService.ResponseModel sendEmail(string token, int idLogin, string[] email, string content, string subject) {
            return base.Channel.sendEmail(token, idLogin, email, content, subject);
        }
        
        public System.Threading.Tasks.Task<env.WWUserService.ResponseModel> sendEmailAsync(string token, int idLogin, string[] email, string content, string subject) {
            return base.Channel.sendEmailAsync(token, idLogin, email, content, subject);
        }
        
        public void resendEmail(string token) {
            base.Channel.resendEmail(token);
        }
        
        public System.Threading.Tasks.Task resendEmailAsync(string token) {
            return base.Channel.resendEmailAsync(token);
        }
        
        public env.WWUserService.ResponseModel getSuperintendent(string token, int idLogin, int idUser) {
            return base.Channel.getSuperintendent(token, idLogin, idUser);
        }
        
        public System.Threading.Tasks.Task<env.WWUserService.ResponseModel> getSuperintendentAsync(string token, int idLogin, int idUser) {
            return base.Channel.getSuperintendentAsync(token, idLogin, idUser);
        }
        
        public env.WWUserService.ResponseModel login(string username, string encodedPassword, System.Nullable<int> role) {
            return base.Channel.login(username, encodedPassword, role);
        }
        
        public System.Threading.Tasks.Task<env.WWUserService.ResponseModel> loginAsync(string username, string encodedPassword, System.Nullable<int> role) {
            return base.Channel.loginAsync(username, encodedPassword, role);
        }
    }
}
