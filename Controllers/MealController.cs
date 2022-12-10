using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using meal_service.Models;
using meal_service.Services;
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
        private readonly IMealService _mealService;

        public MealController(ILogger<MealController> logger, IMealService meal_service)
        {
            _logger = logger;
            _mealService = meal_service;
        }

        [HttpGet("/api/v1/meals")]
        public async Task<IEnumerable<Meal>> GetMealsAsync()
        {
            var result = await _mealService.GetMeals();
            return result;
        }

        [HttpGet("/api/v1/meals/{id}")]
        public Task<Meal> GetMeal(Guid id)
        {
            return null;
        }

        [HttpPost("/api/v1/meals")]
        public HttpResponse CreateMeal()
        {
            return null;
        }

        [HttpPut("/api/v1/meals/{id}")]
        public Meal UpdateMeal()
        {
            return null;
        }

        [HttpDelete("/api/v1/meals/{id}")]
        public HttpResponse DeleteMeal()
        {
            return null;
        }
    }
}
