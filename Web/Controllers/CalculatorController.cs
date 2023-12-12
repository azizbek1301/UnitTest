using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("Add/{left}/{right}")]
        public int Get(int left, int right)
        {
            throw new NotImplementedException();
        }
    }
}
