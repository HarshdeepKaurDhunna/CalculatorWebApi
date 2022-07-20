using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
       

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
           return Ok(Calculator_Logic.Calculator.Addition(left, right));
            

        }

        [HttpGet("Subtract")]
        public double getSubtractionResult()
        {
            var result = 0;
            return result;

        }

        [HttpGet("Multiply")]
        public double getMultiplyResult()
        {
            var result = 0;
            return result;

        }
        [HttpGet("Division")]
        public double getDivisionResult()
        {
            var result = 0;
            return result;

        }
        
    }
}
