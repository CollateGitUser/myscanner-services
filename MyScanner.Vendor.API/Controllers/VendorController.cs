using Microsoft.AspNetCore.Mvc;

namespace MyScanner.Vendor.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendorController : ControllerBase
    {         
        private readonly ILogger<VendorController> _logger;

        public VendorController(ILogger<VendorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/vendor/get")]
        public string Get()
        {
            return "Vendor API... running";
        }
    }
}