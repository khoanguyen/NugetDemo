using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;

namespace DemoLibrary
{
    public class ProfilerBehaviorExtensionElement : BehaviorExtensionElement
    {
        private const string OutputKey = "output";

        [ConfigurationProperty(OutputKey)]
        public string Output
        {
            get { return (this[OutputKey] as string) ?? string.Empty; }
            set { this[OutputKey] = value; }
        }
        

        public override Type BehaviorType
        {
            get { return typeof (ServiceProfiler); }
        }

        protected override object CreateBehavior()
        {
            return new ServiceProfiler(Output);
        }
    }
}
