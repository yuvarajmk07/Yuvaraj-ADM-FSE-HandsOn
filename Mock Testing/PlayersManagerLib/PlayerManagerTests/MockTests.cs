using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using PlayersManagerLib;


namespace PlayerManagerTests
{
    [TestFixture]
    public class MockTests
    {
        Mock<IPlayerMapper> mock;
        Player player;
        [OneTimeSetUp]
        public void setUp()
        {
             mock = new Mock<IPlayerMapper>();
            
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateNewPlayer()
        {
             player = Player.RegisterNewPlayer("");
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyName()
        {
            
             player = Player.RegisterNewPlayer("", mock.Object);
        }


        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void PlayerAlreadyExistsInDatabase()
        {
            
            mock.Setup(x => x.IsPlayerNameExistsInDb(It.IsAny<string>())).Returns(true);

            player = Player.RegisterNewPlayer("Test", mock.Object);
        }


        [Test]
        [TestCase("Tesla")]
        [TestCase("Einstein")]
        public void CreateNewPlayerDoesNotAlreadyExistInDatabase(string name)
        {
            
            mock.Setup(x => x.IsPlayerNameExistsInDb(It.IsAny<string>())).Returns(false);

            player = Player.RegisterNewPlayer(name, mock.Object);

            Assert.AreEqual(name, player.Name);
            Assert.AreEqual(23, player.Age);
            Assert.AreEqual("India", player.Country);
            Assert.AreEqual(30, player.NoOfMatches);
        }
    }
}
