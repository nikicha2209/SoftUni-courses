using System;
using System.Collections.Generic;

namespace FightingArena.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class ArenaTests
    {
        private Warrior first;
        private Warrior second;
        private Arena arena;

        [SetUp]
        public void SetUp()
        {
            first = new Warrior("First", 25, 70);
            second = new Warrior("Second", 20, 65);
            arena = new Arena();
        }

        [Test]
        public void ConstructorShouldSetTheValuesCorrectly()
        {
            List<Warrior> list = new List<Warrior>();
            CollectionAssert.AreEqual(list, arena.Warriors);
        }

        [Test]
        public void PropertyWarriorsShouldReturnWarriorObject()
        {
            arena.Enroll(first);
            arena.Enroll(second);
            List<Warrior> expectedWarriors = new List<Warrior>() { first, second };
            Assert.AreEqual(expectedWarriors, arena.Warriors);
        }

        [Test]
        public void EnrollMethodShouldIncreaseWarriorsCount()
        {
            arena.Enroll(first);
            arena.Enroll(second);
            Assert.AreEqual(arena.Warriors.Count, arena.Count);
            Assert.AreEqual(2, arena.Count);
        }

        [Test]
        public void EnrollMethodsShouldNotAddWarriorsWithExistingNames()
        {
            arena.Enroll(first);
            Assert.Throws<InvalidOperationException>(() => arena.Enroll(first));
        }

        [Test]
        public void AttackerNotPresentInTheArenaCantFight()
        {
            arena.Enroll(first);
            arena.Enroll(second);
            Assert.Throws<InvalidOperationException>(() => arena.Fight("Missing attacker", second.Name));
        }

        [Test]
        public void DefenderNotPresentInTheArenaCantFight()
        {
            arena = new Arena();
            arena.Enroll(first);
            arena.Enroll(second);
            Assert.Throws<InvalidOperationException>(() => arena.Fight(first.Name, "Missing defender"));
        }

        [Test]
        public void TwoWarriorsFightAsExpected()
        {
            arena = new Arena();
            arena.Enroll(first);
            arena.Enroll(second);

            int expectedHpFirst = first.HP - second.Damage;
            int expectedHpSecond = second.HP - first.Damage;

            arena.Fight(first.Name, second.Name);
            Assert.IsTrue(first.HP == expectedHpFirst && second.HP == expectedHpSecond);
        }
    }
}
