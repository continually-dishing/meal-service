using System;
namespace meal_service.Models
{
    public class Meal
    {
        public String Name { get; set; }
        public bool Vegetarian { get; set; }
        public bool Vegan { get; set; }
        public string [] Ingredients { get; set; }
        public DateTime PrepTime { get; set; }
        public DateTime TotalTime { get; set; }
    }
}
