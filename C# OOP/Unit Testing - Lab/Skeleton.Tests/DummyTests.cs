using System;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        private Dummy dummy;

        [SetUp]
        public void SetUp()
        {
            dummy = new Dummy(20, 8);
        }


        [Test]
        public void DummyLosesHealth_WhenItIsAttacked()
        {
            dummy.TakeAttack(2);
            Assert.AreEqual(dummy.Health, 18);
            
        }

        [Test]

        public void DeadDummy_ThrowsAnException_IfAttacked()
        {
            dummy.TakeAttack(20);
            Assert.Throws<InvalidOperationException>(() =>
            {
                dummy.TakeAttack(1);
            });
        }

        [Test]
        public void DeadDummy_CanGiveXP()
        {
            dummy.TakeAttack(20);
            Assert.AreEqual(dummy.GiveExperience(), 8);
        }

        [Test]
        public void AliveDummy_CannotGiveXP()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                dummy.GiveExperience();
            });
        }
    }
}