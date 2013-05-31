using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Dispatcher;
using System.IO;
using System.Diagnostics;

namespace DemoLibrary
{
    public class ProfilingOperationInvoker : IOperationInvoker
    {
        private readonly DispatchOperation _operation;
        private readonly IOperationInvoker _original;

        public string OutputPath { get; set; }

        public ProfilingOperationInvoker(DispatchOperation dispatchOperation, string outputPath)
        {
            _operation = dispatchOperation;
            _original = dispatchOperation.Invoker;
            IsSynchronous = _original.IsSynchronous;
            OutputPath = outputPath;
        }

        public object[] AllocateInputs()
        {
            return _original.AllocateInputs();
        }

        public object Invoke(object instance, object[] inputs, out object[] outputs)
        {
            using (var writer = GetWriter())
            {
                var stopWatch = Stopwatch.StartNew();
                var result = _original.Invoke(instance, inputs, out outputs);
                stopWatch.Stop();
                WriteLog(writer, stopWatch);
                writer.Flush();
                return result;
            }
        }

        public IAsyncResult InvokeBegin(object instance, object[] inputs, AsyncCallback callback, object state)
        {
            return _original.InvokeBegin(instance, inputs, callback, state);
        }

        public object InvokeEnd(object instance, out object[] outputs, IAsyncResult result)
        {
            return _original.InvokeEnd(instance, out outputs, result);
        }

        public bool IsSynchronous
        {
            get;
            private set;
        }

        private StreamWriter GetWriter()
        {
            var fs = File.Exists(OutputPath) ?
                File.Open(OutputPath, FileMode.Append) :
                File.Open(OutputPath, FileMode.CreateNew);

            return new StreamWriter(fs);                
        }

        private void WriteLog(StreamWriter writer, Stopwatch stopwatch)
        {
            writer.WriteLine(string.Format("{0}.{1},{2}",
                                _operation.Parent
                                          .EndpointDispatcher
                                          .ChannelDispatcher
                                          .Host
                                          .Description
                                          .ServiceType
                                          .FullName,
                                _operation.Name,
                                stopwatch.ElapsedMilliseconds));
        }
    }
}
