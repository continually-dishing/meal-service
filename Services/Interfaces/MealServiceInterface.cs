using System;
using meal_service.Models;

namespace meal_service.Services
{
    public interface MealServiceInterface
    {
        public Meal getMeals();
        public Meal getMeal(Guid id);
        public Meal createMeal(Meal input);
        public Meal updateMeal(Guid id);
        public Meal deleteMeal(Guid id);
    }
}
