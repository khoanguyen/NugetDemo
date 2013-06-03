using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.ServiceModel;
using System.Text;
using NugetDemo.Services;

namespace NugetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new PeopleServiceClient())
            {
                for (var i = 0; i < 10; i++)
                {
                    var people = client.FirstOneThousand();
                    foreach (var person in people)
                    {
                        Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
                    }
                }
            }
        }
    }
}
