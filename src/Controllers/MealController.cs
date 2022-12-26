using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using meal_service.Models;
using meal_service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace meal_service
{
    [ApiController]
    [Route("[controller]")]
    public class MealController : ControllerBase
    {
        private readonly IMealService _mealService;

        public MealController( IMealService meal_service)
        {
            _mealService = meal_service;
        }

        [HttpGet("/api/v1/meals")]
        public async Task<IActionResult> GetMeals()
        {
            var result = await _mealService.GetMeals();
            return StatusCode(200, result);
        }

        [HttpGet("/api/v1/meals/{id}")]
        public async Task<IActionResult> GetMeal(Guid id)
        {
            var result = await _mealService.GetMeal(id);
            if (result == null)
            {
                return StatusCode(404, null);
            }
            else
            {
                return StatusCode(200, result);
            }
        }

        [HttpPost("/api/v1/meals")]
        public async Task<Meal> CreateMeal(Meal mealInput)
        {
            var result = await _mealService.CreateMeal(mealInput);

            return result;
        }

        [HttpPut("/api/v1/meals/{id}")]
        public Meal UpdateMeal()
        {
            return null;
        }

        [HttpDelete("/api/v1/meals/{id}")]
        public async Task<IActionResult> DeleteMeal(Guid id)
        {
            var result = await _mealService.DeleteMeal(id);
            if (result == null)
            {
                return StatusCode(404);
            }
            else
            {
                return StatusCode(200, result);
            }
        }
    }
}
