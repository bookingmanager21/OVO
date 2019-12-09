using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Api.OvoTestProject.UnitTests
{
    public class BaseTestSetup
    {

        protected HttpClient _httpClient;
        
        [SetUp]
        public void Setup()
        {
        
            var appFactory = new WebApplicationFactory<Startup>()
                .WithWebHostBuilder(builder =>
                {
                    builder.ConfigureServices(services => { });
                });

            _httpClient = appFactory.CreateClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        [TearDown]
        public void TearDown()
        {
        }
    }
}
