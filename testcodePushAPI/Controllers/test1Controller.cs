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
                    int a = 1;
        int b = 0;
        int c = a / b; // division by zero — bug Sonar bắt được

        return Ok(c);            

        }
    }
}
