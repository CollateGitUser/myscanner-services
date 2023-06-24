using Microsoft.AspNetCore.Mvc;

namespace MyScanner.Media.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MediaController : ControllerBase
    {
        
        private readonly ILogger<MediaController> _logger;

        public MediaController(ILogger<MediaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/media/get")]
        public string Get()
        {
            return "Media API... running";
        }
    }
}