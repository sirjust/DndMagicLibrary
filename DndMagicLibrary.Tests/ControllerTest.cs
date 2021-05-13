using DndMagicLibrary.Controllers;
using DndMagicLibrary.Data.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DndMagicLibrary.Tests.Controllers
{
    [TestClass]
    public class ControllerTests
    {
        ClassController _classController;
        SpellController _spellController;
        HomeController _homeController;
        Mock<IApiHelper> _helper;

        [TestInitialize]
        public void Start()
        {
            _helper = new Mock<IApiHelper>();
            _helper.Setup(x => x.GetSpellData(It.IsAny<string>())).ReturnsAsync(new Models.Spell());
            _classController = new ClassController(_helper.Object);
            _spellController = new SpellController(_helper.Object);
            _homeController = new HomeController();
        }

        [TestMethod]
        public void Home_Index_Returns_ViewResult()
        {
            // Arrange

            // Act
            ViewResult result = _homeController.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Class_Index_Returns_ViewResult()
        {
            // Arrange

            // Act
            ViewResult result = _classController.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task Spell_Index_Returns_ViewResult()
        {
            // Arrange

            // Act
            ViewResult result = await _spellController.Spell("test") as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
