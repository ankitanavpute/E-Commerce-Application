using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetFirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsApiController : ControllerBase
    {
        public List<string> fruits = new List<string>()
        {
            "Apple",
            "Banana",
            "Mango",
            "Cherry",
            "Grapes"
        };
        [HttpGet]
        public List<string> GetFruits() 
        {
            return fruits;




        }
    }
}
