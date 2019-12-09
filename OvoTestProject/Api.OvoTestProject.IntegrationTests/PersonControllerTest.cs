using Api.OvoTestProject.Services.Entities;
using Newtonsoft.Json;
using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace Api.OvoTestProject.IntegrationTests
{
    [TestFixture]
    public class PersonControllerTest : BaseTestSetup
    {
        [Test]
        public void CheckPersonIsCreated()
        {
            var person = new Person { Name = "wil" };
            
            var stringContent = new StringContent(JsonConvert.SerializeObject(person), Encoding.UTF8, "application/json");
            var postResult = HttpClient.PostAsync("Persons", stringContent).Result;

            postResult.StatusCode.ShouldBe(HttpStatusCode.Created);

            person = JsonConvert.DeserializeObject<Person>(postResult.Content.ReadAsStringAsync().Result);

            person.Name.ShouldBe("WIL");
        }
    }
}
