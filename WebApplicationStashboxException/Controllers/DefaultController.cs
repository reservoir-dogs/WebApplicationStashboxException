using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStashboxException.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DefaultController : Controller
    {
        public DefaultController(IParent parent)
        {
        }

        [HttpGet]
        public string Hello()
        {
            return "Hello";
        }
    }
}
