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
    public class StarshipsControllerTests
    {
        private Mock<IRepository<Starship>> starshipRepositoryMock =
            new Mock<IRepository<Starship>>();

        private Mock<ILogger<ResourceControllerBase<Starship>>> loggerMock =
            new Mock<ILogger<ResourceControllerBase<Starship>>>();

        private StarshipsController controller;

        [SetUp]
        public void Setup()
        {
            this.controller = new StarshipsController(this.starshipRepositoryMock.Object, this.loggerMock.Object);
        }

        [Test]
        public async Task GetAll_ReturnsCorrectData()
        {
            // Arrange
            this.starshipRepositoryMock.Setup(repo => repo.GetAll()).ReturnsAsync(GetTestData());

            // Act
            var result = await controller.GetList();

            // Assert
            var okResult = result.Should().BeOfType<OkObjectResult>().Subject;
            var starships = okResult.Value.Should().BeAssignableTo<IEnumerable<Starship>>().Subject;
            starships.Should().BeEquivalentTo(GetTestData());
        }

        [Test]
        public async Task GetPage_ReturnsCorrectDataAndCount()
        {
            // Arrange
            this.starshipRepositoryMock.Setup(repo => repo.GetPage(0)).ReturnsAsync(GetTestData().Take(Constants.ItemsPerPage));

            // Act
            var result = await controller.GetPage(0);

            // Assert
            var okResult = result.Should().BeOfType<OkObjectResult>().Subject;
            var starships = okResult.Value.Should().BeAssignableTo<IEnumerable<Starship>>().Subject;
            starships.Should().BeEquivalentTo(GetTestData().Take(Constants.ItemsPerPage));
            starships.Count().Should().BeLessOrEqualTo(Constants.ItemsPerPage);
        }

        [Test]
        public async Task Count_ReturnsCorrectValue()
        {
            // Arrange
            this.starshipRepositoryMock.Setup(repo => repo.Count()).ReturnsAsync(GetTestData().Count());

            // Act
            var result = await controller.GetCount();

            // Assert
            var okResult = result.Should().BeOfType<OkObjectResult>().Subject;
            var starshipsCount = okResult.Value.Should().BeAssignableTo<int>().Subject;
            starshipsCount.Should().Be(GetTestData().Count());
        }

        /// <summary>
        /// Reads sample data from JSON file.
        /// </summary>
        /// <returns>IEnumerable of type Starship</returns>
        private IEnumerable<Starship> GetTestData()
        {
            string dataJson = File.ReadAllText(Path.Combine("SampleData", "starships.json"));

            IEnumerable<Starship> dataList = JsonConvert.DeserializeObject<IEnumerable<Starship>>(dataJson);

            return dataList;
        }
    }
}