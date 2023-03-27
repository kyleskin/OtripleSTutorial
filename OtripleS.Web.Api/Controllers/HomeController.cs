using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OtripleS.Web.Api.Models;

namespace OtripleS.Web.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HomeController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> Get() => Ok("Hello, Mario. The princess is in another castle.");
}