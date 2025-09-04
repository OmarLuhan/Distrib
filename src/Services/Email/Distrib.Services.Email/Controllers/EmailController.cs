using Microsoft.AspNetCore.Mvc;

namespace Distrib.Services.Email.Controllers;

[ApiController]
[Route("[controller]")]
public class EmailController : ControllerBase
{
    [HttpPost("send")]
    public ActionResult<EmailDto> Send([FromBody] EmailDto email)
    {
         return  Ok(email);
    }
}
public record EmailDto(string From, string To, string Subject, string Body);