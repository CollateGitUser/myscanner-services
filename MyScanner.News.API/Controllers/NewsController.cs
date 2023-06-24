using Microsoft.AspNetCore.Mvc;

namespace MyScanner.News.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewsController : ControllerBase
    {
        
        private readonly ILogger<NewsController> _logger;

        public NewsController(ILogger<NewsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/news/get")]
        public string Get()
        {
            return "News API... running";
        }
    }
}