using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ValuesController : ControllerBase
{
    [HttpGet]
    [Authorize]
    public IActionResult Get()
    {
        var userInfo = new
        {
            Name = "Madieson Sumbingco",
            Section = "BSCS32E1",
            Course = "Computer Science",
            FunFacts = new[]
            {
                "I love fries.",
                "I hate summer, especially the heat.",
                "Hmmm???? I love to hang out with my friends.",
                "I really love to explore new things.",
                "My social battery drains quickly.",
                "I get angry when I'm hungry.",
                "I'm an only child.",
                "I take my rest days seriously.",
                "Sleepyhead.",
                "My coping mechanism when I'm sad is to eat my favorite food."
            }
        };

        return Ok(userInfo);
    }
}