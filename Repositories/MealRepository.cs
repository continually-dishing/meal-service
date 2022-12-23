using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;
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
            //specifying file path
            var filePath = "/Users/mikayla/source/repos/meal-service/Repositories/data.json";
            //opening file
            using FileStream openStream = File.OpenRead(filePath);
            //reading from file and creating list of meal items
            var items = await JsonSerializer.DeserializeAsync<List<Meal>>(openStream);
            return items;
        }

        public async Task<Meal> GetMeal(Guid id)
        {
            //specifying file path
            var filePath = "/Users/mikayla/source/repos/meal-service/Repositories/data.json";
            //opening file
            using FileStream openStream = File.OpenRead(filePath);
            //reading from file and creating list of meal items
            var items = await JsonSerializer.DeserializeAsync<List<Meal>>(openStream);
            var item = items.Find(x => x.ID.Equals(id));
            return item;
        }

        public async Task<Meal> CreateMeal(Meal input)
        {
            //specifying file path
            var filePath = "/Users/mikayla/source/repos/meal-service/Repositories/data.json";
            //opening file
            using FileStream openStream = File.OpenRead(filePath);
            //reading from file and creating list of meal items
            var items = await JsonSerializer.DeserializeAsync<List<Meal>>(openStream);
            //appending list to add new input
            items.Add(input);
            //serializing list to JSON objects
            string json = JsonSerializer.Serialize(items);
            //writing JSON values to file
            File.WriteAllText(filePath, json);
            return input;
        }

        public async Task<Meal> DeleteMeal(Guid id)
        {
            //specifying file path
            var filePath = "/Users/mikayla/source/repos/meal-service/Repositories/data.json";
            //opening file
            using FileStream openStream = File.OpenRead(filePath);
            //reading from file and creating list of meal items
            var items = await JsonSerializer.DeserializeAsync<List<Meal>>(openStream);
            //find item by ID
            var item = items.Find(x => x.ID.Equals(id));
            //once found remove
            items.Remove(item);
            //serializing list to JSON objects
            string json = JsonSerializer.Serialize(items);
            //writing JSON values to file
            File.WriteAllText(filePath, json);
            return item;
        }

        public Meal UpdateMeal(Guid id)
        {
            throw new NotImplementedException();
        }

    }
}
