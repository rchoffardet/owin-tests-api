using System.Web.Http;

namespace FullTest.Api.Controllers
{
    [RoutePrefix("hello")]
    public class HelloController : ApiController
    {
        [HttpGet]
        [Route("{name}")]
        public string Hello(string name = "World")
        {
            return $"Hello {name}!";
        }
    }
}
