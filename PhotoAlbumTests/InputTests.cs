using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoAlbum;
namespace PhotoAlbumTests
{
    [TestClass]
    public class InputTests
    {
        Logic logic = new Logic();

        [TestMethod]
        public void NegativeInputTest()
        {
            //Arrange

            logic.album = -1;

            //Act
            bool shouldBeFalse =logic.CheckUserInput(logic.album.ToString());

            //Assert
            Assert.IsFalse(shouldBeFalse);
        }

        [TestMethod]
        public void TooHighInputTest()
        {
            //Arrange

            logic.album = 101;

            //Act
            bool shouldBeFalse = logic.CheckUserInput(logic.album.ToString());

            //Assert
            Assert.IsFalse(shouldBeFalse);
        }

        [TestMethod]
        public void CorrectInputTest1()
        {
            //Arrange

            logic.album = 1;

            //Act
            bool shouldBeTrue = logic.CheckUserInput(logic.album.ToString());

            //Assert
            Assert.IsTrue(shouldBeTrue);
        }

        [TestMethod]
        public void CorrectInputTest2()
        {
            //Arrange

            logic.album = 100;

            //Act
            bool shouldBeTrue = logic.CheckUserInput(logic.album.ToString());

            //Assert
            Assert.IsTrue(shouldBeTrue);
        }

        [TestMethod]
        public void CorrectInputTest3()
        {
            //Arrange

            logic.album = 50;

            //Act
            bool shouldBeTrue = logic.CheckUserInput(logic.album.ToString());

            //Assert
            Assert.IsTrue(shouldBeTrue);
        }
    }
}