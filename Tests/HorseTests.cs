using NUnit.Framework;
using HorseLibrary;

namespace UnitTests
{
    public class HorseTests
    {
        [Test]
        public void SayNeigh()
        {
            var horse = new Horse();

            string noise = horse.MakeNoise();

            Assert.AreEqual("Neigh!", noise);
        }

        [Test]
        public void DontSayWoof()
        {
            var horse = new Horse();

            string noise = horse.MakeNoise();

            Assert.AreNotEqual("Woof!", noise);
        }
    }
}
