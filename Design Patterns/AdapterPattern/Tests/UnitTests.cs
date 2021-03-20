using System;
using NUnit.Framework;
using AdapterPattern;
namespace Tests
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void MPHtoKMPH()
        {
            Movable bugattiVeyron = new BugattiVeyron(); 
            MovableAdapter bugattiVeyronAdapter = new MovableAdapterImpl(bugattiVeyron);
            Assert.AreEqual(bugattiVeyronAdapter.getSpeed(), 431.30312);

        }
    }
}
