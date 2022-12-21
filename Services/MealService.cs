using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using meal_service.Models;
using meal_service.Repositories;
using meal_service.Repositories.Interfaces;

namespace meal_service.Services
{
    public class MealService : IMealService
    {
        private readonly IMealRepository _meal_repo;

        public MealService(IMealRepository meal_repo)
        {
            _meal_repo = meal_repo;
        }

        public async Task<IEnumerable<Meal>> GetMeals()
        {
            var result = await _meal_repo.GetMeals();
            return result;
        }

        public Meal GetMeal(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<Meal> CreateMeal(Meal input)
        {
            var result = await _meal_repo.CreateMeal(input);
            return result;
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
