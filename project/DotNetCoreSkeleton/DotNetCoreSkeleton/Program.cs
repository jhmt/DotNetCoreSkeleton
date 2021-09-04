using System;
using Query.Models;

namespace DotNetCoreSkeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var classToTest = new ClassToTest();
            var contact = classToTest.MethodToTest(Guid.NewGuid());

            Console.WriteLine(contact);
        }
    }
}
