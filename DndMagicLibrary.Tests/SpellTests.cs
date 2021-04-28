using DndMagicLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DndMagicLibrary.Tests
{
    [TestClass]
    public class SpellTests
    {
        [TestMethod]
        public void ConvertSpellName_Should_Change_To_Lower_When_Single_Word()
        {
            // Arrange
            var spell = new Spell();
            var name = "Shield";
            var expected = "shield";

            // Act
            var actual = spell.ConvertSpellName(name);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertSpellName_Should_Split_Correctly_When_Multiple_Words()
        {
            // Arrange
            var spell = new Spell();
            var name = "Acid Arrow";
            var expected = "acid-arrow";

            // Act
            var actual = spell.ConvertSpellName(name);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveNames_Should_Remove_Names_With_Apostrophes()
        {
            // Arrange
            var spell = new Spell();
            var name = "Otto's Irresistible Dance";
            var expected = "irresistible-dance";

            // Act
            var actual = spell.ConvertSpellName(name);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
