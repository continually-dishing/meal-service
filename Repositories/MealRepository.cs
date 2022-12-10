using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using meal_service.Models;
using meal_service.Repositories.Interfaces;

namespace meal_service.Repositories
{
    public class MealRepository: IMealRepository
    {
        public MealRepository()
        {
        }


        public async Task<List<Meal>> GetMeals()
        {

            var filePath = "/Users/mikayla/source/repos/meal-service/Repositories/data.json";

            using FileStream openStream = File.OpenRead(filePath);
            var items =await JsonSerializer.DeserializeAsync<List<Meal>>(openStream);

            return items;
        }

        public Task<Meal> GetMeal(Guid id)
        {
            throw new NotImplementedException();
        }

        public Meal CreateMeal(Meal input)
        {
            throw new NotImplementedException();
        }

        public Meal DeleteMeal(Guid id)
        {
            throw new NotImplementedException();
        }

        public Meal UpdateMeal(Guid id)
        {
            throw new NotImplementedException();
        }

    }
}
