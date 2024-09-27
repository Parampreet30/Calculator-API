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

    [HttpGet("Add")]
    public decimal Add(decimal left, decimal right)
    {
        return left + right
    }

    [HttpGet("Subtract")]
    public decimal Subtract(decimal left, decimal right)
    {
        return left - right
    }
}