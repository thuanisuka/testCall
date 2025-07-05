using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace testcodePushAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class test1Controller : ControllerBase
    {
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Simulate deletion logic
            // In a real application, you would typically delete an item from a database or collection here.
            // Return a 204 No Content response to indicate successful deletion
            //comment new
            //new 2
            return NoContent();
        }
    }
}
