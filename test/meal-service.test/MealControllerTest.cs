using AutoFixture;
using meal_service.Models;
using meal_service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace meal_service.test;

    public class MealControllerTest
    {
        private readonly Mock<IMealService> _mockService; //creating mock variables
        private readonly MealController _controller;
        private Fixture _fixture;

        public MealControllerTest()
        {
            _fixture = new Fixture();
            _mockService = new Mock<IMealService>();
            _controller = new MealController(_mockService.Object);
        }


        [Fact]
        public async Task GetMeals_Success()
        {
            Task<IEnumerable<Meal>> mealList = _fixture.Create<Task<IEnumerable<Meal>>>();
            _mockService.Setup(service => service.GetMeals()).Returns(mealList);
            var response = await _controller.GetMeals();
            var obj = response as ObjectResult;
            Assert.Equal(200, obj.StatusCode);
        }

        [Fact]
        public async Task GetSingleMeal_Success()
        {
            Meal mockMeal = _fixture.Create<Meal>();
            Guid guidInput = Guid.NewGuid();
            _mockService.Setup(service => service.GetMeal(guidInput)).Returns(Task.FromResult(mockMeal));
            var response = await _controller.GetMeal(guidInput);
            var obj = response as ObjectResult;
            var actualMeal = obj.Value as Meal;
            Assert.Equal(mockMeal, actualMeal);
            Assert.Equal(200, obj.StatusCode);
        }

    [Fact]
        public async Task CreateMeals_Success()
        {
            Meal mealInput = _fixture.Create<Meal>();
            _mockService.Setup(service => service.CreateMeal(mealInput)).Returns(Task.FromResult(mealInput));
            var response = await _controller.CreateMeal(mealInput);
            var obj = response as ObjectResult;
            var actualMeal = obj.Value as Meal;
            Assert.Equal(mealInput, actualMeal);
            Assert.Equal(200, obj.StatusCode);
        }

        [Fact]
        public async Task DeleteMeals_Success()
        {
            Meal mockMeal = _fixture.Create<Meal>();
            Guid guidInput = Guid.NewGuid();
            _mockService.Setup(service => service.DeleteMeal(guidInput)).Returns(Task.FromResult(mockMeal));
            var response = await _controller.DeleteMeal(guidInput);
            var obj = response as ObjectResult;
            var actualMeal = obj.Value as Meal;
            Assert.Equal(mockMeal, actualMeal);
            Assert.Equal(200, obj.StatusCode);
        }
}

