using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using meal_service.Models;

namespace meal_service.Services
{
    public interface IMealService
    {
        public Task<IEnumerable<Meal>> GetMeals();
        public Meal GetMeal(Guid id);
        public Meal CreateMeal(Meal input);
        public Meal UpdateMeal(Guid id);
        public Meal DeleteMeal(Guid id);
    }
}
