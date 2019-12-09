using Api.Safe.Well.ApiCustomHttpResponses;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace Api.OvoTestProject.Controllers
{
    [EnableCors("AllowAll")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected IActionResult HandleException(Exception exception)
        {
            return new ObjectResult(new ApiResponse((int)HttpStatusCode.InternalServerError, exception.ToString())) { StatusCode = (int)HttpStatusCode.InternalServerError };
        }
    }
}