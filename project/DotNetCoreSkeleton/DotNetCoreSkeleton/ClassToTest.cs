using System;
using Query.Models;

namespace DotNetCoreSkeleton
{
    public class ClassToTest
    {
        public Contact MethodToTest(Guid contactGuid)
        {
            var contact = new Contact {ContactId = contactGuid};

            return contact;
        }
    }
}
