using Microsoft.AspNetCore.Mvc;

namespace DvlaProject.Controllers;


[ApiController]
[Route("")]
public class BaseController : ControllerBase
{
    [HttpGet]
     public string Get()
     {
         return "Hello World!!";
     }
}