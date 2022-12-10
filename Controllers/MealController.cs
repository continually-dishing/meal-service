using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using meal_service.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace meal_service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MealController : ControllerBase
    {

        private readonly ILogger<MealController> _logger;

        public MealController(ILogger<MealController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> GetMeals()
        {
            return null;
        }

        [HttpPost]
        public HttpResponse CreateMeal()
        {
            return null;
        }

        [HttpPut]
        public Meal UpdateMeal()
        {
            return null;
        }

        [HttpDelete]
        public HttpResponse DeleteMeal()
        {
            return null;
        }
    }
}
