using System;
using Query.Models;

namespace DotNetCoreSkeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Instantiate Contact
            var contact = new Contact();

            Console.WriteLine(contact);
        }
    }
}
