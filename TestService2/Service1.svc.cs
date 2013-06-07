using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TestService2.DataTransferObjects;
using TestService2.Model;

namespace TestService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public PersonName[] GetPeople(string amount)
        {
            var numberOfPeople = 0;
            int.TryParse(amount, out numberOfPeople);
            numberOfPeople = numberOfPeople == 0 ? 100 : numberOfPeople;
            using (var context = new AdventureWorksEntities())
            {
                var result = context.People
                                    .Take(numberOfPeople)
                                    .Select(p => new PersonName
                                        {
                                            FirstName = p.FirstName,
                                            LastName = p.LastName,
                                            FullName = p.FirstName + " " + p.LastName
                                        });
                return result.ToArray();
            }
        }
    }
}
