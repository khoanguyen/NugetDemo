using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CustomerService" in code, svc and config file together.
    public class PeopleService : IPeopleService
    {
        public Person[] FirstOneThousand()
        {
            using (var context = new AdventureWorksEntities())
            {
                var result = context.People
                                    .Take(1000)
                                    .ToArray();
                return result;
            }
        }
    }
}
