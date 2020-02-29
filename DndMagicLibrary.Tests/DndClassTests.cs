using System;
using System.Threading.Tasks;
using DndMagicLibrary.Data;
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
            DndClass bard = new DndClass("Bard", Descriptions.DescriptionsDictionary["Bard"], 2, 1);

            // act
            var spellcastingData = await bard.GetSpellcastingData();

            // assert
            Assert.IsNotNull(spellcastingData.Url);
        }

        [TestMethod]
        public async Task GetClassData_ReturnsCorrectData()
        {
            // Arrange
            DndClass dndClass = new DndClass("Bard", Descriptions.DescriptionsDictionary["Bard"], 2, 1);
            string expected = "Bard";

            // Act
            dndClass = await dndClass.GetClassData(dndClass);

            // Assert
            Assert.AreEqual(expected, dndClass.SpellCasting.Class);
        }
    }
}
