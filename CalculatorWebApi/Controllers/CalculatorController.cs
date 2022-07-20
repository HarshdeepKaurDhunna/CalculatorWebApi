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

        [HttpGet]
        public Calculator getAddResult()
        {
            var rng = new Random();
            return new Calculator();
            
        }
        [HttpGet]
        public Calculator getSubtractionResult()
        {
            var rng = new Random();
            return new Calculator();

        }
        [HttpGet]
        public Calculator getMultiplyResult()
        {
            var rng = new Random();
            return new Calculator();

        }
        [HttpGet]
        public Calculator getDivisionResult()
        {
            var rng = new Random();
            return new Calculator();

        }
        
    }
}
