using System;
using Xunit;

namespace DotNetCoreSkeleton.Tests
{
    public class ClassToTestTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var contactGuid = Guid.NewGuid();
            var classToTest = new ClassToTest();

            // Act
            var result = classToTest.MethodToTest(contactGuid);

            // Assert
            Assert.Equal(contactGuid, result.ContactId);
        }
    }
}
