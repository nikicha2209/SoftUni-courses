using System;

namespace CarManager.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class CarManagerTests
    {
        private const string DEF_MAKE = "Lamborghini";
        private const string DEF_MODEL = "Urus";
        private const double DEF_FUELCONSUMPTION = 20;
        private const double DEF_FUELCAPACITY = 80;
        private Car car;

        [SetUp]
        public void SetUp()
        {
            car = new Car(DEF_MAKE, DEF_MODEL, DEF_FUELCONSUMPTION, DEF_FUELCAPACITY);
        }

        [Test]
        public void ConstructorCratesACarCorrectly()
        {
            Assert.AreEqual("Lamborghini", car.Make);
            Assert.AreEqual("Urus", car.Model);
            Assert.AreEqual(20, car.FuelConsumption);
            Assert.AreEqual(80, car.FuelCapacity);
            Assert.AreEqual(0, car.FuelAmount);
        }


        [TestCase(null)]
        [TestCase("")]
        public void PropertyMakeCannotBeNullOrEmpty(string make)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car(make, DEF_MODEL, DEF_FUELCONSUMPTION, DEF_FUELCAPACITY);
            });
        }

        [TestCase(null)]
        [TestCase("")]
        public void PropertyModelCannotBeNullOrEmpty(string model)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car(DEF_MAKE, model, DEF_FUELCONSUMPTION, DEF_FUELCAPACITY);
            });
        }

        [TestCase(-10)]
        [TestCase(0)]
        public void PropertyFuelConsumptionCannotBeZeroOrNegative(double fuelConsumption)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car(DEF_MAKE, DEF_MODEL, fuelConsumption, DEF_FUELCAPACITY);
            });
        }

        [TestCase(-10)]
        [TestCase(0)]
        public void PropertyFuelCapacityCannotBeZeroOrNegative(double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car(DEF_MAKE, DEF_MODEL, DEF_FUELCONSUMPTION, fuelCapacity);
            });
        }

        [Test]
        public void PropertyFuelAmountCannotBeANegativeNumber()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                car.Refuel(-10);
            });
        }

        [TestCase(0)]
        [TestCase(-12)]
        public void FuelToRefuelCannotBeZeroOrNegative(double fuelToRefuel)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                car.Refuel(fuelToRefuel);
            });
        }

        [Test]
        public void TheRefuelMethodShouldIncreaseTheFuelAmountIfTheGivenNumberIsPositive()
        {
            car.Refuel(4);
            Assert.AreEqual(4, car.FuelAmount);
        }

        [Test]
        public void FuelAmountShouldNotBeMoreThanFuelCapacity()
        {
            car.Refuel(90);
            Assert.AreEqual(80,  car.FuelAmount);
        }

        [Test]
        public void TheDriveMethodShouldDecreaseTheFuelAmount()
        {
            car.Refuel(30);
            car.Drive(5);
            Assert.AreEqual(29, car.FuelAmount);
        }

        [Test]
        public void TheDriveMethodShouldThrowAnErrorIfFuelNeededAmountIsMoreThanFuelAmount()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                car.Drive(100);
            });

        }
    }
}