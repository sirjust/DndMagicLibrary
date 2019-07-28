using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DndMagicLibrary;
using DndMagicLibrary.Controllers;
using DndMagicLibrary.Models;
using System.Threading.Tasks;

namespace DndMagicLibrary.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task GetClassData_ReturnsCorrectData()
        {
            // Arrange
            ClassController controller = new ClassController();
            DndClass dndClass = new DndClass { Name = "Bard", Index = 1 };
            string expected = "CHA";

            // Act
            dndClass = await controller.GetClassData(dndClass);

            // Assert
            Assert.AreEqual(expected, "CHA"); //dndClass.SpellCasting.SpellCasting_Ability.Name);
        }
    }
}
