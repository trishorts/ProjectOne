using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectOne.Classes;

namespace ProjectOne.UnitTests
{
    [TestClass]
    public class AdditionTests
    {
        [TestMethod]
        public void Addition_CanAdd()
        {
            //Arrange
            int expected = 5;
            Addition a = new Addition();

            //Act
            int actual = a.Add(2, 3);


            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
