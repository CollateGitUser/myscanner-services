using Microsoft.AspNetCore.Mvc;

namespace MyScanner.Identity.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IdentityController : ControllerBase
    { 
        private readonly ILogger<IdentityController> _logger;

        public IdentityController(ILogger<IdentityController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/identity/get")]
        public string Get()
        {
            return "Identity Service.... running...";
        }
    }
} 