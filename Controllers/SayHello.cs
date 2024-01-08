using Microsoft.AspNetCore.Mvc;

namespace SayHello.Controllers;

[ApiController]
[Route("SayHello")]

    public class SayHello : ControllerBase
    {
        [HttpGet]
        [Route("Greet/{name}")]
        public string sayHello(string name)
        {
            return $"Hello {name}!";
        }
    }
