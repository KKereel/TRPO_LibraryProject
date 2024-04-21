using Microsoft.VisualStudio.TestTools.UnitTesting;
using MAIN_LIBRARY;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Organizaciya_Constructor_ValidInput_ShouldPass()
        {
            // Arrange
            string nazvanie = "Название организации";
            string yuridicheskiyAdres = "Юридический адрес";
            string fakticheskiyAdres = "Фактический адрес";

            // Act
            Organizaciya organizaciya = new Organizaciya(nazvanie, yuridicheskiyAdres, fakticheskiyAdres);

            // Assert
            Assert.IsNotNull(organizaciya);
        }
        [TestMethod]
        public void Organizaciya_Constructor_InvalidInput_ShouldFail()
        {
            // Arrange
            string nazvanie = "Название организации";
            string yuridicheskiyAdres = null; // Подаем невалидное значение
            string fakticheskiyAdres = "Фактический адрес";

            // Act
            Organizaciya organizaciya = null;
            try
            {
                organizaciya = new Organizaciya(nazvanie, yuridicheskiyAdres, fakticheskiyAdres);
            }
            catch (ArgumentNullException)
            {
                // Ignoring ArgumentNullException as it is expected
            }

            // Assert
            Assert.IsNull(organizaciya);
        }
    }
}
