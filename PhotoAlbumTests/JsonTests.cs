using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoAlbum;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhotoAlbumTests
{
    [TestClass]
    public class JsonTests
    {
        Logic logic = new Logic();

        [TestMethod]
        public async Task JsonTest1()
        {
            //Arrange

            logic.album = 3;

            //Act
            var json = await logic.GetJson();
            List<Photo> photos = logic.ConvertJson(json);
            var photo = photos[0];

            //Assert
            Assert.AreEqual(101 ,photo.id);
        }

        [TestMethod]
        public async Task JsonTest2()
        {
            //Arrange

            logic.album = 3;

            //Act
            var json = await logic.GetJson();
            List<Photo> photos = logic.ConvertJson(json);
            var photo = photos[49];

            //Assert
            Assert.AreEqual(150, photo.id);
        }

        [TestMethod]
        public async Task JsonTest3()
        {
            //Arrange

            logic.album = 6;

            //Act
            var json = await logic.GetJson();
            List<Photo> photos = logic.ConvertJson(json);
            var photo = photos[0];

            //Assert
            Assert.AreEqual("voluptatibus nihil a", photo.title);
        }

        [TestMethod]
        public async Task JsonTest4()
        {
            //Arrange

            logic.album = 6;

            //Act
            var json = await logic.GetJson();
            List<Photo> photos = logic.ConvertJson(json);
            var photo = photos[49];

            //Assert
            Assert.AreEqual("minus error et eveniet", photo.title);
        }
    }
}