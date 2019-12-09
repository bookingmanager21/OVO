using Api.OvoTestProject.Services.Interfaces;
using Api.OvoTestProject.Services.InterfacesImplementation;
using NUnit.Framework;
using Shouldly;
using System;

namespace Api.OvoTestProject.UnitTests
{
    [TestFixture]
    public class PersonManagementTests : BaseTestSetup
    {
        [Test]
        public void CheckStringIsConvertedToUpperCase()
        {
            var personManager = ServiceContainer.ServiceProvider.GetService(typeof(IPersonManager)) as PersonManager;
            string value = "hello";

            value = personManager.ToUppper(value);
            value.ShouldBe("HELLO");
        }
    }
}
