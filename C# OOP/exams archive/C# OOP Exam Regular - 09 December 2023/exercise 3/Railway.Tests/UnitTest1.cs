namespace Railway.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Tests
    {
        private RailwayStation railwayStation;
        [SetUp]
        public void Setup()
        {
            railwayStation = new RailwayStation("Grand Central");
        }

        [Test]
        public void ConstructorShouldSetTheValuesCorrectly()
        {
            Assert.AreEqual(railwayStation.Name, "Grand Central");
            Assert.AreEqual(0, railwayStation.ArrivalTrains.Count);
            Assert.AreEqual(0, railwayStation.DepartureTrains.Count);
        }



        [TestCase(null)]
        [TestCase(" ")]
        [TestCase("")]
        public void TheNameShouldNotBeNullOrWhiteSpace(string name)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                railwayStation = new RailwayStation(name);
            });
        }

        [Test]
        public void NewArrivalOnBoardShouldAddATrainToTheArrivalList()
        {
            railwayStation.NewArrivalOnBoard("first train");
            Assert.AreEqual(1, railwayStation.ArrivalTrains.Count);
        }


        [Test]
        public void WhenTheTrainArriveItShouldBeRemovedFromTheArrivalList()
        {
            railwayStation.NewArrivalOnBoard("first train");
            railwayStation.NewArrivalOnBoard("second train");

            railwayStation.TrainHasArrived("first train");

            Assert.AreEqual(1, railwayStation.ArrivalTrains.Count);

        }

        [Test]
        public void IfThereIsATrainBeforeTheGivenOneTheMethodShouldNotDoAnything()
        {
            railwayStation.NewArrivalOnBoard("first train");
            railwayStation.NewArrivalOnBoard("second train");

            railwayStation.TrainHasArrived("second train");

            Assert.AreEqual(2, railwayStation.ArrivalTrains.Count);
        }

        [Test]
        public void IfThereIsATrainBeforeTheGivenOneTheMethodShouldReturnAMessage()
        {
            railwayStation.NewArrivalOnBoard("first train");
            railwayStation.NewArrivalOnBoard("second train");

            string result = railwayStation.TrainHasArrived("second train");

            Assert.AreEqual(result, "There are other trains to arrive before second train.");
        }

        [Test]
        public void IfTheGivenTrainIsTheLastInDepartureListTheMethodShouldReturnAMessage()
        {
            railwayStation.NewArrivalOnBoard("first train");
            railwayStation.NewArrivalOnBoard("second train");

            string result = railwayStation.TrainHasArrived("first train");

            Assert.AreEqual(result, "first train is on the platform and will leave in 5 minutes.");
        }



        [Test]
        public void IfTheGivenTrainIsTheLastInDepartureListTheMethodShouldReturnTrue()
        {
            railwayStation.DepartureTrains.Enqueue("first train");
            railwayStation.DepartureTrains.Enqueue("second train");
            Assert.IsTrue(railwayStation.TrainHasLeft("first train"));
        }

        [Test]
        public void IfTheGivenTrainIsTheLastInDepartureListItShouldBeRemoved()
        {
            railwayStation.DepartureTrains.Enqueue("first train");
            railwayStation.DepartureTrains.Enqueue("second train");
            railwayStation.TrainHasLeft("first train");
            Assert.AreEqual(1, railwayStation.DepartureTrains.Count);
        }

        [Test]
        public void IfTheGivenTrainIsNotTheLastInDepartureListTheMethodShouldReturnFalse()
        {
            railwayStation.DepartureTrains.Enqueue("first train");
            railwayStation.DepartureTrains.Enqueue("second train");
            Assert.IsFalse(railwayStation.TrainHasLeft("second train"));
        }
    }
}