﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.36279
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quiz.QuizServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Test", Namespace="http://schemas.datacontract.org/2004/07/Quiz.Service.WcfService.Model")]
    [System.SerializableAttribute()]
    public partial class Test : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Quiz.QuizServiceReference.Question[] QuestionsField;
        
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
        public Quiz.QuizServiceReference.Question[] Questions {
            get {
                return this.QuestionsField;
            }
            set {
                if ((object.ReferenceEquals(this.QuestionsField, value) != true)) {
                    this.QuestionsField = value;
                    this.RaisePropertyChanged("Questions");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Question", Namespace="http://schemas.datacontract.org/2004/07/Quiz.Service.WcfService.Model")]
    [System.SerializableAttribute()]
    public partial class Question : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string QuestionTextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Quiz.QuizServiceReference.Variant[] VariantsField;
        
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
        public string QuestionText {
            get {
                return this.QuestionTextField;
            }
            set {
                if ((object.ReferenceEquals(this.QuestionTextField, value) != true)) {
                    this.QuestionTextField = value;
                    this.RaisePropertyChanged("QuestionText");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Quiz.QuizServiceReference.Variant[] Variants {
            get {
                return this.VariantsField;
            }
            set {
                if ((object.ReferenceEquals(this.VariantsField, value) != true)) {
                    this.VariantsField = value;
                    this.RaisePropertyChanged("Variants");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Variant", Namespace="http://schemas.datacontract.org/2004/07/Quiz.Service.WcfService.Model")]
    [System.SerializableAttribute()]
    public partial class Variant : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageUriField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VariantTextField;
        
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
        public string ImageUri {
            get {
                return this.ImageUriField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageUriField, value) != true)) {
                    this.ImageUriField = value;
                    this.RaisePropertyChanged("ImageUri");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VariantText {
            get {
                return this.VariantTextField;
            }
            set {
                if ((object.ReferenceEquals(this.VariantTextField, value) != true)) {
                    this.VariantTextField = value;
                    this.RaisePropertyChanged("VariantText");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Answer", Namespace="http://schemas.datacontract.org/2004/07/Quiz.Service.WcfService.Model")]
    [System.SerializableAttribute()]
    public partial class Answer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int questionIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> variantIdField;
        
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
        public int questionId {
            get {
                return this.questionIdField;
            }
            set {
                if ((this.questionIdField.Equals(value) != true)) {
                    this.questionIdField = value;
                    this.RaisePropertyChanged("questionId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> variantId {
            get {
                return this.variantIdField;
            }
            set {
                if ((this.variantIdField.Equals(value) != true)) {
                    this.variantIdField = value;
                    this.RaisePropertyChanged("variantId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TransferedImage", Namespace="http://schemas.datacontract.org/2004/07/Quiz.Service.WcfService.Model")]
    [System.SerializableAttribute()]
    public partial class TransferedImage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FilenameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] dataField;
        
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
        public string Filename {
            get {
                return this.FilenameField;
            }
            set {
                if ((object.ReferenceEquals(this.FilenameField, value) != true)) {
                    this.FilenameField = value;
                    this.RaisePropertyChanged("Filename");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] data {
            get {
                return this.dataField;
            }
            set {
                if ((object.ReferenceEquals(this.dataField, value) != true)) {
                    this.dataField = value;
                    this.RaisePropertyChanged("data");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="QuizServiceReference.IAuth")]
    public interface IAuth {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuth/SignIn", ReplyAction="http://tempuri.org/IAuth/SignInResponse")]
        bool SignIn(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuth/SignIn", ReplyAction="http://tempuri.org/IAuth/SignInResponse")]
        System.Threading.Tasks.Task<bool> SignInAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuth/SignUp", ReplyAction="http://tempuri.org/IAuth/SignUpResponse")]
        void SignUp(string name, string last_name, string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuth/SignUp", ReplyAction="http://tempuri.org/IAuth/SignUpResponse")]
        System.Threading.Tasks.Task SignUpAsync(string name, string last_name, string login, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuthChannel : Quiz.QuizServiceReference.IAuth, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthClient : System.ServiceModel.ClientBase<Quiz.QuizServiceReference.IAuth>, Quiz.QuizServiceReference.IAuth {
        
        public AuthClient() {
        }
        
        public AuthClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool SignIn(string login, string password) {
            return base.Channel.SignIn(login, password);
        }
        
        public System.Threading.Tasks.Task<bool> SignInAsync(string login, string password) {
            return base.Channel.SignInAsync(login, password);
        }
        
        public void SignUp(string name, string last_name, string login, string password) {
            base.Channel.SignUp(name, last_name, login, password);
        }
        
        public System.Threading.Tasks.Task SignUpAsync(string name, string last_name, string login, string password) {
            return base.Channel.SignUpAsync(name, last_name, login, password);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="QuizServiceReference.ITestOperation")]
    public interface ITestOperation {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestOperation/GetTest", ReplyAction="http://tempuri.org/ITestOperation/GetTestResponse")]
        Quiz.QuizServiceReference.Test GetTest(int testId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestOperation/GetTest", ReplyAction="http://tempuri.org/ITestOperation/GetTestResponse")]
        System.Threading.Tasks.Task<Quiz.QuizServiceReference.Test> GetTestAsync(int testId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestOperation/GetAnswers", ReplyAction="http://tempuri.org/ITestOperation/GetAnswersResponse")]
        Quiz.QuizServiceReference.Answer[] GetAnswers(int questionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestOperation/GetAnswers", ReplyAction="http://tempuri.org/ITestOperation/GetAnswersResponse")]
        System.Threading.Tasks.Task<Quiz.QuizServiceReference.Answer[]> GetAnswersAsync(int questionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestOperation/GetPassedTests", ReplyAction="http://tempuri.org/ITestOperation/GetPassedTestsResponse")]
        Quiz.QuizServiceReference.Test[] GetPassedTests(int UserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestOperation/GetPassedTests", ReplyAction="http://tempuri.org/ITestOperation/GetPassedTestsResponse")]
        System.Threading.Tasks.Task<Quiz.QuizServiceReference.Test[]> GetPassedTestsAsync(int UserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestOperation/GetAvailableTests", ReplyAction="http://tempuri.org/ITestOperation/GetAvailableTestsResponse")]
        Quiz.QuizServiceReference.Test[] GetAvailableTests(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestOperation/GetAvailableTests", ReplyAction="http://tempuri.org/ITestOperation/GetAvailableTestsResponse")]
        System.Threading.Tasks.Task<Quiz.QuizServiceReference.Test[]> GetAvailableTestsAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestOperation/PassTest", ReplyAction="http://tempuri.org/ITestOperation/PassTestResponse")]
        void PassTest(int userId, int testId, double score);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestOperation/PassTest", ReplyAction="http://tempuri.org/ITestOperation/PassTestResponse")]
        System.Threading.Tasks.Task PassTestAsync(int userId, int testId, double score);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITestOperationChannel : Quiz.QuizServiceReference.ITestOperation, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TestOperationClient : System.ServiceModel.ClientBase<Quiz.QuizServiceReference.ITestOperation>, Quiz.QuizServiceReference.ITestOperation {
        
        public TestOperationClient() {
        }
        
        public TestOperationClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TestOperationClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestOperationClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestOperationClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Quiz.QuizServiceReference.Test GetTest(int testId) {
            return base.Channel.GetTest(testId);
        }
        
        public System.Threading.Tasks.Task<Quiz.QuizServiceReference.Test> GetTestAsync(int testId) {
            return base.Channel.GetTestAsync(testId);
        }
        
        public Quiz.QuizServiceReference.Answer[] GetAnswers(int questionId) {
            return base.Channel.GetAnswers(questionId);
        }
        
        public System.Threading.Tasks.Task<Quiz.QuizServiceReference.Answer[]> GetAnswersAsync(int questionId) {
            return base.Channel.GetAnswersAsync(questionId);
        }
        
        public Quiz.QuizServiceReference.Test[] GetPassedTests(int UserId) {
            return base.Channel.GetPassedTests(UserId);
        }
        
        public System.Threading.Tasks.Task<Quiz.QuizServiceReference.Test[]> GetPassedTestsAsync(int UserId) {
            return base.Channel.GetPassedTestsAsync(UserId);
        }
        
        public Quiz.QuizServiceReference.Test[] GetAvailableTests(int userId) {
            return base.Channel.GetAvailableTests(userId);
        }
        
        public System.Threading.Tasks.Task<Quiz.QuizServiceReference.Test[]> GetAvailableTestsAsync(int userId) {
            return base.Channel.GetAvailableTestsAsync(userId);
        }
        
        public void PassTest(int userId, int testId, double score) {
            base.Channel.PassTest(userId, testId, score);
        }
        
        public System.Threading.Tasks.Task PassTestAsync(int userId, int testId, double score) {
            return base.Channel.PassTestAsync(userId, testId, score);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="QuizServiceReference.IFileTransfer")]
    public interface IFileTransfer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileTransfer/UploadFile", ReplyAction="http://tempuri.org/IFileTransfer/UploadFileResponse")]
        string UploadFile(byte[] data, string filename);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileTransfer/UploadFile", ReplyAction="http://tempuri.org/IFileTransfer/UploadFileResponse")]
        System.Threading.Tasks.Task<string> UploadFileAsync(byte[] data, string filename);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileTransfer/DownloadImage", ReplyAction="http://tempuri.org/IFileTransfer/DownloadImageResponse")]
        Quiz.QuizServiceReference.TransferedImage DownloadImage(string url);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileTransfer/DownloadImage", ReplyAction="http://tempuri.org/IFileTransfer/DownloadImageResponse")]
        System.Threading.Tasks.Task<Quiz.QuizServiceReference.TransferedImage> DownloadImageAsync(string url);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFileTransferChannel : Quiz.QuizServiceReference.IFileTransfer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FileTransferClient : System.ServiceModel.ClientBase<Quiz.QuizServiceReference.IFileTransfer>, Quiz.QuizServiceReference.IFileTransfer {
        
        public FileTransferClient() {
        }
        
        public FileTransferClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FileTransferClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileTransferClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileTransferClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string UploadFile(byte[] data, string filename) {
            return base.Channel.UploadFile(data, filename);
        }
        
        public System.Threading.Tasks.Task<string> UploadFileAsync(byte[] data, string filename) {
            return base.Channel.UploadFileAsync(data, filename);
        }
        
        public Quiz.QuizServiceReference.TransferedImage DownloadImage(string url) {
            return base.Channel.DownloadImage(url);
        }
        
        public System.Threading.Tasks.Task<Quiz.QuizServiceReference.TransferedImage> DownloadImageAsync(string url) {
            return base.Channel.DownloadImageAsync(url);
        }
    }
}
