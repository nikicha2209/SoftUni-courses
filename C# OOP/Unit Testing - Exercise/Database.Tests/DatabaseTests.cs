using System;
using NUnit.Framework.Internal;

namespace Database.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class DatabaseTests
    {
        private Database db;

        [SetUp]
        public void SetUp()
        {
            db = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
        }

        [Test]
        public void ConstructorShouldAcceptNoMoreThan16Elements()
        {
            Assert.Throws<InvalidOperationException>( () =>
            {
                db = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17);
            });
        }

        [Test]
        public void ConstructorShouldSetTheValuesIntoTheArray()
        {
            Assert.AreEqual(16, db.Count);
        }

        [Test]
        public void TheAddMethodIncreaseTheNumbersInTheArray()
        {
            db = new Database(1, 2, 3);
            db.Add(4);
            Assert.AreEqual(4, db.Count);
        }

        [Test]
        public void WhenTheElementsAre16_TheAddOperationShouldThrowAnError()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                db.Add(17);
            });
        }


        [Test]
        public void TheRemoveMethodRemovesAnElementFromTheArray()
        {
            db.Remove();
            Assert.AreEqual(15, db.Count);
        }

        [Test]
        public void WhenTheCountIsZero_TheRemoveMethodShouldReturnAnError()
        {
            db = new Database();

            Assert.Throws<InvalidOperationException>(() =>
            {
                db.Remove();
            });
        }

        [Test]
        public void TheFetchMethod_ShouldReturnTheSameArray()
        {
            int[] excpectedArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16};
            Assert.AreEqual(excpectedArray, db.Fetch());

        }
    }
}
