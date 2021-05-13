using DndMagicLibrary.Data.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DndMagicLibrary.Tests
{
    [TestClass]
    public class DndClassTests
    {
        IApiHelper _helper;

        [TestInitialize]
        public void Start()
        {
            _helper = new Mock<IApiHelper>().Object;
        }

        //[TestMethod]
        //public async Task GetSpellcastingData_RetrievesInfo()
        //{
        //    // arrange
        //    DndClass bard = new DndClass("Bard", Descriptions.DescriptionsDictionary["Bard"], 2, 1);

        //    // act
        //    var spellcastingData = await bard.GetSpellcastingData();

        //    // assert
        //    Assert.IsNotNull(spellcastingData.Url);
        //}

        //[TestMethod]
        //public async Task GetClassData_ReturnsCorrectData()
        //{
        //    // Arrange
        //    DndClass dndClass = new DndClass(_helper, "Bard", Descriptions.DescriptionsDictionary["Bard"], 2, 1);
        //    string expected = "Bard";

        //    // Act
        //    dndClass = await dndClass.GetClassData(dndClass);

        //    // Assert
        //    Assert.AreEqual(expected, dndClass.SpellCasting.Class);
        //}
    }
}
