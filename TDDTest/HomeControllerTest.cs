using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.Controllers;

namespace TDDTest
{
    public class HomeControllerTest
    {
        [Fact]
        public void IndexTest()
        {
            //Arrange
            HomeController controller = new HomeController();
            //Act
            var result = controller.Index();
            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
