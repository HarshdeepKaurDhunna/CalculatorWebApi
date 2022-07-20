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
        public double getAddResult()
        {
            var result = 0;
            return result;
            
        }
        [HttpGet]
        public double getSubtractionResult()
        {
            var result = 0;
            return result;

        }
        [HttpGet]
        public double getMultiplyResult()
        {
            var result = 0;
            return result;

        }
        [HttpGet]
        public double getDivisionResult()
        {
            var result = 0;
            return result;

        }
        
    }
}
