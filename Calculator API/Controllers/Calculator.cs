using Microsoft.AspNetCore.Mvc;

// Create API Controller
[Route("api/[controller]")]
public class Calculator : ControllerBase
{
    // Addition Method
    [HttpGet("add")]
    public decimal Add(decimal a, decimal b)
    {
        return a + b;
    }

    // Subtraction Method
    [HttpGet("subtract")]
    public decimal Subtract(decimal a, decimal b)
    {
        return a - b;
    }

    // Multiplication Method
    [HttpGet("multiply")]
    public decimal Multiply(decimal a, decimal b)
    {
        return a * b;
    }

    // Division Method
    [HttpGet("divide")]
    public IActionResult Divide(decimal a, decimal b)
    {
        if (b == 0)
        {
            return BadRequest("Division by zero is undefined.");
        }

        decimal result = a / b;
        return Ok(result);
    }

    // Modulo Method
    [HttpGet("modulo")]
    public IActionResult Modulo(decimal a, decimal b)
    {
        if (b == 0)
        {
            return BadRequest("a modulo 0 is undefined.");
        }

        decimal result = a % b;
        return Ok(result);
    }
}
