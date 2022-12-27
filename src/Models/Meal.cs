using System;
namespace meal_service.Models
{
    public class Meal
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public bool Vegetarian { get; set; }
        public bool Vegan { get; set; }
        public string [] Ingredients { get; set; }
        public int PrepTime { get; set; }
        public int TotalTime { get; set; }
        public bool BudgetFriendly { get; set; }
        public string Difficulty { get; set; }
    }
}
