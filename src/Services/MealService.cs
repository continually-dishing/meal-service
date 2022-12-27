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

        public async Task<Meal> GetMeal(Guid id)
        {
            var result = await _meal_repo.GetMeal(id);
            return result;
        }

        public async Task<Meal> CreateMeal(Meal input)
        {
            var identifier = Guid.NewGuid(); //generate new guid
            input.ID = identifier; //assign new guid as ID to meal item
            var result = await _meal_repo.CreateMeal(input);
            return result;
        }

        public async Task<Meal> DeleteMeal(Guid id)
        {
            var result = await _meal_repo.DeleteMeal(id);
            return result;
        }

        public Meal UpdateMeal(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
