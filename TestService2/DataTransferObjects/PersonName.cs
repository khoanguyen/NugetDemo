using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TestService2.DataTransferObjects
{
    public class PersonName
    {
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}