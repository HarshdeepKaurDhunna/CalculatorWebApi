using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator_Logic;

namespace CalculatorWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        Calculator? Calc = null;
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        /*
         *@Method Type:  Get 
         *@Action: Add
         */
        [HttpGet("Add")]
        public IActionResult GetAddResult(double left, double right)
        {
           return Ok(Calc.Addition(left, right));
            

        }

        [HttpGet("Subtract")]
        public IActionResult getSubtractionResult(double left, double right)
        {
            return Ok(Calc.Subtraction(left, right));

        }

        [HttpGet("Multiply")]
        public IActionResult getMultiplyResult(double left, double right)
        {
            return Ok(Calc.Multiplication(left, right));

        }
        [HttpGet("Division")]
        public IActionResult getDivisionResult(double left, double right)
        {
            try
            {
                return Ok(Calc.Divide(left, right));
            }
            catch (DivideByZeroException e)
            {
                return BadRequest();

            }

        }
        
    }
}
