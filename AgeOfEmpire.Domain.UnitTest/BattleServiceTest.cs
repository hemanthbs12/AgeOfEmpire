using AgeOfEmpire.Domain.Models;
using AgeOfEmpire.Domain.Services;
using NUnit.Framework;
using System.Collections.Generic;

namespace AgeOfEmpire.Domain.UnitTest
{
    public class BattleServiceTest
    {
        private BattleService _battleService;
        [SetUp]
        public void Setup()
        {
            _battleService = new BattleService();
        }

        [Test]
        public void GetWinnerTest()
        {
            //Arrange
            List<Unit> units = new List<Unit>
            {
                new Unit(1, "RCB", 50, 5),
                new Unit(4, "CSK", 40, 4)
            };

            //Act
            var result = _battleService.GetWinner(units);

            //Assert
            Assert.AreEqual(1, result.Id);
        }
    }
}