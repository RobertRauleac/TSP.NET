﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace System
{
    public class ServiceModel
    {
        public interface IClientChannel
        {
        }

        public class ClientBase<T>
        {
            private string endpointConfigurationName;
            private string remoteAddress;
            private EndpointAddress remoteAddress1;
            private Channels.Binding binding;
            private EndpointAddress remoteAddress2;

            public ClientBase(string endpointConfigurationName)
            {
                this.endpointConfigurationName = endpointConfigurationName;
            }

            public ClientBase(Channels.Binding binding, string endpointConfigurationName)
            {
                this.endpointConfigurationName = endpointConfigurationName;
            }

            public ClientBase(Channels.Binding binding, string endpointConfigurationName)
            {
                this.endpointConfigurationName = endpointConfigurationName;
            }

            public ClientBase(string endpointConfigurationName, string remoteAddress)
            {
                this.endpointConfigurationName = endpointConfigurationName;
                this.remoteAddress = remoteAddress;
            }

            public ClientBase(string endpointConfigurationName, EndpointAddress remoteAddress1)
            {
                this.endpointConfigurationName = endpointConfigurationName;
                this.remoteAddress1 = remoteAddress1;
            }

            public ClientBase(Channels.Binding binding, EndpointAddress remoteAddress2)
            {
                this.binding = binding;
                this.remoteAddress2 = remoteAddress2;
            }

            public object Channel { get; internal set; }
        }

        public class Channels
        {
            public class Binding
            {
            }
        }

        public class EndpointAddress
        {
        }

        internal class OperationContractAttribute : Attribute
        {
            public string ReplyAction { get; set; }
        }

        internal class ServiceContractAttribute : Attribute
        {
            public string ConfigurationName { get; set; }
        }
    }
}