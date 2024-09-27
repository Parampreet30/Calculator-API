using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers;

[ApiController]
[Route("[controller]")]

public class calculator : ControllerBase
{

    private readonly ILogger<calculator>_logger;

    public calculator(ILogger<calculator> logger)
    {
        _logger = logger;
    }
}