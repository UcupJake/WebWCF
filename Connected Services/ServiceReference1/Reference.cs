﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebWCF.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/tambah", ReplyAction="http://tempuri.org/IService1/tambahResponse")]
        double tambah(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/tambah", ReplyAction="http://tempuri.org/IService1/tambahResponse")]
        System.Threading.Tasks.Task<double> tambahAsync(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/kurang", ReplyAction="http://tempuri.org/IService1/kurangResponse")]
        double kurang(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/kurang", ReplyAction="http://tempuri.org/IService1/kurangResponse")]
        System.Threading.Tasks.Task<double> kurangAsync(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/kali", ReplyAction="http://tempuri.org/IService1/kaliResponse")]
        double kali(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/kali", ReplyAction="http://tempuri.org/IService1/kaliResponse")]
        System.Threading.Tasks.Task<double> kaliAsync(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/bagi", ReplyAction="http://tempuri.org/IService1/bagiResponse")]
        double bagi(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/bagi", ReplyAction="http://tempuri.org/IService1/bagiResponse")]
        System.Threading.Tasks.Task<double> bagiAsync(double num1, double num2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebWCF.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebWCF.ServiceReference1.IService1>, WebWCF.ServiceReference1.IService1 {
        
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
        
        public double tambah(double num1, double num2) {
            return base.Channel.tambah(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> tambahAsync(double num1, double num2) {
            return base.Channel.tambahAsync(num1, num2);
        }
        
        public double kurang(double num1, double num2) {
            return base.Channel.kurang(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> kurangAsync(double num1, double num2) {
            return base.Channel.kurangAsync(num1, num2);
        }
        
        public double kali(double num1, double num2) {
            return base.Channel.kali(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> kaliAsync(double num1, double num2) {
            return base.Channel.kaliAsync(num1, num2);
        }
        
        public double bagi(double num1, double num2) {
            return base.Channel.bagi(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> bagiAsync(double num1, double num2) {
            return base.Channel.bagiAsync(num1, num2);
        }
    }
}
