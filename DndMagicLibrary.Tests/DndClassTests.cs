using System;
using System.Threading.Tasks;
using DndMagicLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DndMagicLibrary.Tests
{
    [TestClass]
    public class DndClassTests
    {
        [TestMethod]
        public async Task GetSpellcastingDataRetrievesInfo()
        {
            // arrange
            DndClass bard = new DndClass { Name = "Bard", Index = 2 };

            // act
            var spellcastingData = await bard.GetSpellcastingData(bard.Index);

            // assert
            Assert.IsNotNull(spellcastingData.Url);
        }

        [TestMethod]
        public async Task GetClassData_ReturnsCorrectData()
        {
            // Arrange
            DndClass dndClass = new DndClass { Name = "Bard", Index = 1 };
            string expected = "CHA";

            // Act
            dndClass = await dndClass.GetClassData();

            // Assert
            Assert.AreEqual(expected, dndClass.SpellCasting_Ability.Name);
        }
    }
}
