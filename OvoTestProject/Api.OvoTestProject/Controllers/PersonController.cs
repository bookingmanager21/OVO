using Api.OvoTestProject.Services.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Api.OvoTestProject.Controllers
{
    [ApiController]
    [Route("Persons")]
    public class PersonController : BaseController
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IApplicationServiceLocator _applicationServiceLocator;

        public PersonController(ILogger<WeatherForecastController> logger, IApplicationServiceLocator applicationServiceLocator)
        {
            _logger = logger;
            _applicationServiceLocator = applicationServiceLocator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Person person)
        {
            try
            {
                var result = _applicationServiceLocator.StringManager.ToUppper(person.Name);
                person.Name = result;

                return new CreatedResult(Url.RouteUrl(person.Id), person);
            }
            catch (Exception exception)
            {
                return HandleException(exception);
            }
        }
    }
}
