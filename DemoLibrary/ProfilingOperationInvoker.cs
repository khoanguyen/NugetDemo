using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Dispatcher;
using System.IO;
using System.Diagnostics;

namespace DemoLibrary
{
    public class ProfilingOperationInvoker : IOperationInvoker
    {
        private static object _gate = new object();
        private readonly DispatchOperation _operation;
        private readonly IOperationInvoker _original;
        private static readonly Dictionary<string, StreamWriter> _outputWriters;

        public string OutputPath { get; set; }

        static ProfilingOperationInvoker()
        {
            _outputWriters = new Dictionary<string, StreamWriter>();
        }

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
            var writer = GetWriter(OutputPath);
            var stopWatch = Stopwatch.StartNew();
            var result = _original.Invoke(instance, inputs, out outputs);
            stopWatch.Stop();
            lock (writer)
            {
                WriteLog(writer, stopWatch);
                writer.Flush();
            }
            return result;
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

        private StreamWriter GetWriter(string output)
        {
            if (_outputWriters.ContainsKey(output)) return _outputWriters[output];
            lock (_gate)
            {
                if (_outputWriters.ContainsKey(output)) return _outputWriters[output];
                var fs = File.Exists(OutputPath)
                             ? File.Open(OutputPath, FileMode.Append, FileAccess.Write, FileShare.Read)
                             : File.Open(OutputPath, FileMode.CreateNew, FileAccess.Write, FileShare.Read);

                _outputWriters[output] = new StreamWriter(fs);
            }
            return _outputWriters[output];
        }

        private void WriteLog(StreamWriter writer, Stopwatch stopwatch)
        {
            writer.WriteLine("{0}.{1},{2},{3}",
                             _operation.Parent
                                         .EndpointDispatcher
                                         .ChannelDispatcher
                                         .Host
                                         .Description
                                         .ServiceType
                                         .FullName,
                             _operation.Name,
                             OperationContext.Current.RequestContext.RequestMessage.Properties.Via,
                             stopwatch.ElapsedMilliseconds);
        }
    }
}
