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
         *@parameters: two Numbers
         *This api is used get the result of addition of two numbers
         */
        [HttpGet("Add")]
        public IActionResult GetAddResult(double left, double right)
        {
          
            try
            {
                return Ok(Calc.Addition(left, right)); // call to class library Addition Method and return success
            }
            catch (Exception)
            {
                return BadRequest(); // return bad request if any exception occur to save the application from crashing
            }

        }

        /*
         *@Method Type:  Get 
         *@Action: Subtract
         *@parameters: two Numbers
         *This api is used get the result of Subtraction of two numbers
         */
        [HttpGet("Subtract")]
        public IActionResult getSubtractionResult(double left, double right)
        {
            
            try
            {
                return Ok(Calc.Subtraction(left, right)); // call to class library Subtraction Method and return success
            }
            catch (Exception)
            {
                return BadRequest(); // return bad request if any exception occur to save the application from crashing
            }

        }

        /*
         *@Method Type:  Get 
         *@Action: Multiply
         *@parameters: two Numbers
         *This api is used get the result of Multiplication of two numbers
         */
        [HttpGet("Multiply")]
        public IActionResult getMultiplyResult(double left, double right)
        {
          
            try
            {
                return Ok(Calc.Multiplication(left, right)); // call to class library Multiplication Method and return success
            }
            catch (Exception)
            {
                return BadRequest(); // return bad request if any exception occur to save the application from crashing
            }

        }

        /*
         *@Method Type:  Get 
         *@Action: Division
         *@parameters: two Numbers
         *This api is used get the result of Division of two numbers
         */
        [HttpGet("Division")]
        public IActionResult getDivisionResult(double left, double right)
        {
            try
            {
                return Ok(Calc.Divide(left, right)); // call to class library Divide Method and return success
            }
            catch (DivideByZeroException)
            {
                return BadRequest(); // return bad request if any exception occur to save the application from crashing

            }

        }
        
    }
}
