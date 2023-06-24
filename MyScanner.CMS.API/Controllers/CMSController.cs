using Microsoft.AspNetCore.Mvc;

namespace MyScanner.CMS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CMSController : ControllerBase
    {        
        private readonly ILogger<CMSController> _logger;

        public CMSController(ILogger<CMSController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/cms/get")]
        public string Get()
        {
            return "CMS API... running";
        }
    }
}