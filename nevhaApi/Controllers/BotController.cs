using djddjt;
using Microsoft.AspNetCore.Mvc;

namespace nevhamovnoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class BotController : ControllerBase
{

    private readonly ILogger<BotController> _logger;

    public BotController(ILogger<BotController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task Get()
    {
        await TgBot.Main();
    }
}