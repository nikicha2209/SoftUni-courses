using System;
using ExtendedDatabase;

namespace DatabaseExtended.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        private Person[] people;
        private Database db;


        [SetUp]
        public void SetUp()
        { 
            people = new Person[]
            {
                new Person(1, "Georgi"),
                new Person(2, "Ivan"),
                new Person(3, "Stoyan"),
                new Person(4, "Nikolay"),
                new Person(5, "Nikol"),
                new Person(6, "Yoana"),
                new Person(7, "Dimitar"),
                new Person(8, "Viktor"),
                new Person(9, "Hristiyana"),
                new Person(10, "Yanitsa"),
                new Person(11, "Kalina"),
                new Person(12, "Simona"),
                new Person(13, "Krasimir"),
                new Person(14, "Dragomir")
            };
            db = new Database(people);
        }


        [Test]
        public void TheConstructor_CannotTakeMoreThan16People()
        {
            Person[] people = new Person[17];
            Assert.Throws<ArgumentException>(() =>
            {
                Database db = new Database(people);
            });
        }

        [Test]
        public void TheConstructor_Should_AddTheElementsIntoTheArray()
        {
            Assert.AreEqual(14, db.Count);
        }

        [Test]
        public void TheAddMethod_ShouldWorkCorrectly()
        {
            db.Add(new Person(15, "Anton"));
            Assert.AreEqual(15, db.Count);
        }

        [Test]
        public void TheAddMethod_ShouldThrowAnError_IfThereIs_AlreadyAPerson_WithTheGivenName()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                db.Add(new Person(15, "Viktor"));
            });
        }

        [Test]
        public void TheAddMethod_ShouldThrowAnError_IfThereIs_AlreadyAPerson_WithTheGivenID()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                db.Add(new Person(8, "Petar"));
            });
        }

        [Test]
        public void WhenThePeopleInTheArrayAre16_TheAddMethod_ShouldThrowAnError_WhenTryingToAdd_AnotherPerson()
        {
            db.Add(new Person(15, "Petar"));
            db.Add(new Person(16, "Viktoriya"));
            Assert.Throws<InvalidOperationException>(() =>
            {
                db.Add(new Person(17, "Sasho"));
            });
        }

        [Test]
        public void TheRemoveMethodShouldWorkCorrectly()
        {
            db.Remove();
            Assert.AreEqual(13,  db.Count);
        }

        [Test]
        public void TheRemoveMethodShould_ThrowAnError_IfThereAreNoPeople()
        {
            Database db = new Database();
            Assert.Throws<InvalidOperationException>(() =>
            {
                db.Remove();
            });
        }

        [Test]
        public void FindByUsernameMethodShouldWorkCorrectly()
        {
            Assert.AreSame(db.FindByUsername("Nikol"), people[4]);
        }

        [Test]
        public void FindByUsernameMethod_ShouldThrowAnError_IfTheNameIs_Null()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                db.FindByUsername(null);
            });
        }

        [Test]
        public void FindByUsernameMethod_ShouldThrowAnError_IfTheNameIs_EmptyString()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                db.FindByUsername(string.Empty);
            });
        }

        [Test]
        public void FindByUsernameMethod_ShouldThrowAnError_IfThereIs_NoOneWith_TheGivenName()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                db.FindByUsername("aaaa");
            });
        }

        [Test]
        public void FindByIdMethodShouldWorkCorrectly()
        {
            Assert.AreSame(db.FindById(5), people[4]);
        }

        [Test]
        public void FindByIdMethod_ShouldThrowAnError_IfTheIdIs_Zero()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                db.FindById(-153);
            });
        }

        [Test]
        public void FindByIdMethod_ShouldThrowAnError_IfThereIs_NoOneWith_TheGivenId()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                db.FindById(124);
            });
        }

    }
}