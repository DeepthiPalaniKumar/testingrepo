using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Web.Mvc;
using System.Threading.Tasks;
using NUnit.Framework;
using TestAppt1.Controllers;


namespace ClassLibrary1
{
    [TestFixture]
    public class HomeControllerTest
    {
        [TestCase]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
          /*  ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);*/
        }

        [TestCase]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
           /* ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
            */
        }

        [TestCase]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
           /* ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);*/
        }
    }//add class lib
    [TestFixture]
    public class EmployeeControllerTest
    {
        [TestCase]
        public void Employees()
        {
            // Arrange
            EmployeeController controller = new EmployeeController();

            // Act
           /* ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);*/
        }
    }
    /*public class Class1
    {
    }
    */
}
