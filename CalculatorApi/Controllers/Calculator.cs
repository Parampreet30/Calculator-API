using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers;

[ApiController]
[Route("[controller]")]

public class Calculator : ControllerBase
{

    private readonly ILogger<Calculator>_logger;

    public Calculator(ILogger<Calculator> logger)
    {
        _logger = logger;
    }
}