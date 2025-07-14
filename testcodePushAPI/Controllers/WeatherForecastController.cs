using Microsoft.AspNetCore.Mvc;

namespace SonarScanTestProject.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild"
    };

    [HttpGet]
    public IEnumerable<string> Get()
    {
        var result = new List<string>();
        for (int i = 0; i < Summaries.Length; i++)
        {
            var a = 1; // lỗi: biến khai báo nhưng không dùng
            result.Add(Summaries[i]);
        }

        var b = ""; // lỗi: khai báo biến nhưng không dùng

        return result;
    }
}
