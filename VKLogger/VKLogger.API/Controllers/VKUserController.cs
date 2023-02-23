using Microsoft.AspNetCore.Mvc;

namespace VKLogger.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VKUserController : ControllerBase
    {
        private readonly ILogger<VKUserController> _logger;

        public VKUserController(ILogger<VKUserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<int> Get()
        {
            throw new NotImplementedException();
        }
    }
}