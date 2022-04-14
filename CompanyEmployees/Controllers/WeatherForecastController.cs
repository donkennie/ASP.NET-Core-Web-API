﻿using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyEmployees.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

       /* private readonly IRepositoryManager _repository;
        public WeatherForecastController(IRepositoryManager repository)
        {
            _repository = repository;
        }
       

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {


           // _repository.Company.AnyMethodFromCompanyRepository();
           // _repository.Employee.AnyMethodFromEmployeeRepository();

            return new string[] { "value1", "value2" };
        }
       */

         private ILoggerManager _logger;
         public WeatherForecastController(ILoggerManager logger)
         {
             _logger = logger;
         }


         [HttpGet]
         public IEnumerable<string> Get()
         {
             _logger.LogInfo("Here is info message from our values controller.");
             _logger.LogDebug("Here is debug message from our values controller.");
             _logger.LogWarn("Here is warn message from our values controller.");
             _logger.LogError("Here is an error message from our values controller.");
             return new string[] { "value1", "value2" };
         }


        /*private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }*/

        /* [HttpGet]
         public IEnumerable<WeatherForecast> Get()
         {
             var rng = new Random();
             return Enumerable.Range(1, 5).Select(index => new WeatherForecast
             {
                 Date = DateTime.Now.AddDays(index),
                 TemperatureC = rng.Next(-20, 55),
                 Summary = Summaries[rng.Next(Summaries.Length)]
             })
             .ToArray();
         }*/
    }
}
