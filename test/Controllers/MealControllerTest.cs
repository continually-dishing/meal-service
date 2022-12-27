using System;
using AutoFixture;
using meal_service.Models;
using meal_service.Repositories.Interfaces;
using meal_service.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace meal_service.Test.Controllers
{
	public class MealControllerTest
	{
        private readonly Mock<IMealService> _mockService;
        private readonly MealController _controller;
        private Fixture _fixture;

        public MealControllerTest()
		{
            _fixture = new Fixture();
            _mockService = new Mock<IMealService>();
            _controller= new MealController(_mockService.Object);
        }

        public async Task CreateMeal_Success()
        {
           
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
}

