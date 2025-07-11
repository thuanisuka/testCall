using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace testcodePushAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class test1Controller : ControllerBase
    {
        [HttpDelete("{id}")]
        public IActionResult Delete(int Number1, int Number2)
        {
            int Number3 = Number1 + Number2;
            if (Number3 < 0)
            {
                return BadRequest("The sum of the numbers cannot be negative.");
            }
            int result = Number1 - Number2;
            if (result < 0)
            {
                return BadRequest("The result of the subtraction cannot be negative.");
            }
            int number = Number1 * Number2;
            if (number < 0)
            {
                return BadRequest("The product of the numbers cannot be negative.");
            }
            int number5 = Number1 / Number2;
            if (number5 < 0)
            {
                return BadRequest("The division result cannot be negative.");
            }
            return NoContent();
        }
    }
}
