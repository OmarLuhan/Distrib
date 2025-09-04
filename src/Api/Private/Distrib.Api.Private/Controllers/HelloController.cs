using Microsoft.AspNetCore.Mvc;

namespace Distrib.Api.Private.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{
    
    [HttpGet(Name = "hello")]
    public ActionResult<string> Get()
    {
       return "hello private";
    }
}