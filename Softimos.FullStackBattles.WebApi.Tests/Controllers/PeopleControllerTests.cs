using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;
using Softimos.FullStackBattles.DAL;
using Softimos.FullStackBattles.DAL.Repositories;
using Softimos.FullStackBattles.DTO;
using Softimos.FullStackBattles.WebApi.Controllers;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Softimos.FullStackBattles.WebApi.Tests.Controllers
{
    [ExcludeFromCodeCoverage]
    public class PeopleControllerTests
    {
        private Mock<IRepository<Person>> personRepositoryMock =
            new Mock<IRepository<Person>>();

        private Mock<ILogger<ResourceControllerBase<Person>>> loggerMock =
            new Mock<ILogger<ResourceControllerBase<Person>>>();

        private PeopleController controller;

        [SetUp]
        public void Setup()
        {
            this.controller = new PeopleController(this.personRepositoryMock.Object, this.loggerMock.Object);
        }

        [Test]
        public async Task GetAll_ReturnsCorrectData()
        {
            // Arrange
            this.personRepositoryMock.Setup(repo => repo.GetAll()).ReturnsAsync(GetTestData());

            // Act
            var result = await controller.GetList();

            // Assert
            var okResult = result.Should().BeOfType<OkObjectResult>().Subject;
            var people = okResult.Value.Should().BeAssignableTo<IEnumerable<Person>>().Subject;
            people.Should().BeEquivalentTo(GetTestData());
        }

        [Test]
        public async Task GetPage_ReturnsCorrectDataAndCount()
        {
            // Arrange
            this.personRepositoryMock.Setup(repo => repo.GetPage(0)).ReturnsAsync(GetTestData().Take(Constants.ItemsPerPage));

            // Act
            var result = await controller.GetPage(0);

            // Assert
            var okResult = result.Should().BeOfType<OkObjectResult>().Subject;
            var people = okResult.Value.Should().BeAssignableTo<IEnumerable<Person>>().Subject;
            people.Should().BeEquivalentTo(GetTestData().Take(Constants.ItemsPerPage));
            people.Count().Should().BeLessOrEqualTo(Constants.ItemsPerPage);
        }

        [Test]
        public async Task Count_ReturnsCorrectValue()
        {
            // Arrange
            this.personRepositoryMock.Setup(repo => repo.Count()).ReturnsAsync(GetTestData().Count());

            // Act
            var result = await controller.GetCount();

            // Assert
            var okResult = result.Should().BeOfType<OkObjectResult>().Subject;
            var peopleCount = okResult.Value.Should().BeAssignableTo<int>().Subject;
            peopleCount.Should().Be(GetTestData().Count());
        }

        /// <summary>
        /// Reads sample data from JSON file.
        /// </summary>
        /// <returns>IEnumerable of type Person</returns>
        private IEnumerable<Person> GetTestData()
        {
            string dataJson = File.ReadAllText(Path.Combine("SampleData", "people.json"));

            IEnumerable<Person> dataList = JsonConvert.DeserializeObject<IEnumerable<Person>>(dataJson);

            return dataList;
        }
    }
}