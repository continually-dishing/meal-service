using AutoFixture;
using meal_service.Models;
using meal_service.Services;
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
    }

