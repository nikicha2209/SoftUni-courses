using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        private Axe axe;
        private Dummy dummy;

        [SetUp]
        public void SetUp()
        {
            axe = new Axe(3, 2);
            dummy = new Dummy(20, 8);
        }

        [Test]
        public void AxeLoses_DurabilityPoints_AfterEachAttack()
        {
            axe.Attack(dummy);
            Assert.AreEqual(axe.DurabilityPoints, 1);
        }

        [Test]
        public void AttackingWithBrokenAxe_ShouldThrowAnExc()
        {
            axe.Attack(dummy);
            axe.Attack(dummy);

            Assert.Throws<InvalidOperationException>(() =>
            {
                axe.Attack(dummy);
            });
        }
    }
}