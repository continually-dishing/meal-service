using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using meal_service.Models;

namespace meal_service.Repositories.Interfaces
{
    public interface IMealRepository
    {
        public Task<List<Meal>> GetMeals();
        public Task<Meal> GetMeal(Guid id);
        public Task<Meal> CreateMeal(Meal input);
        public Meal UpdateMeal(Guid id);
        public Task<Meal> DeleteMeal(Guid id);
    }
}
