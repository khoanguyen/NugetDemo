using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Description;

namespace DemoLibrary
{
    public class ServiceProfiler : Attribute, IServiceBehavior, IOperationBehavior
    {
        
        public string OutputPath { get; private set; }

        public ServiceProfiler(string outputPath)
        {
            OutputPath = outputPath;
        }

        #region IServiceBehavior Implementation
        public void AddBindingParameters(ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase)
        {
            foreach (var operation in serviceDescription.Endpoints
                                                       .SelectMany(ep => ep.Contract.Operations))
            {
                operation.Behaviors.Add(new ServiceProfiler(OutputPath));
            }
        }

        public void Validate(ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase)
        {
        } 
        #endregion
        
        #region IOperationBehavior Implementation
        public void AddBindingParameters(OperationDescription operationDescription, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {            
        }

        public void ApplyClientBehavior(OperationDescription operationDescription, System.ServiceModel.Dispatcher.ClientOperation clientOperation)
        {                           
        }

        public void ApplyDispatchBehavior(OperationDescription operationDescription, System.ServiceModel.Dispatcher.DispatchOperation dispatchOperation)
        {
            dispatchOperation.Invoker = new ProfilingOperationInvoker(dispatchOperation, OutputPath);
        }

        public void Validate(OperationDescription operationDescription)
        {            
        } 
        #endregion
    }
}
