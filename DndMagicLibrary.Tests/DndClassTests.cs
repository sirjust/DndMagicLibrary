using System;
using DndMagicLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DndMagicLibrary.Tests
{
    [TestClass]
    public class DndClassTests
    {
        [TestMethod]
        public void GetSpellcastingDataRetrievesInfo()
        {
            // arrange
            DndClass bard = new DndClass { Name = "Bard", Index = 2 };

            // act
            var spellcastingData = bard.GetSpellcastingData(bard.Index);

            // assert
            Assert.IsNotNull(spellcastingData);
        }
    }
}
