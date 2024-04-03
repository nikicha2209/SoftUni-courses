namespace Television.Tests
{
    using System;
    using System.Diagnostics;
    using NUnit.Framework;
    public class Tests
    {
        private TelevisionDevice device;

        [SetUp]
        public void Setup()
        {
            device = new TelevisionDevice("Samsung", 400, 28, 16);
        }

        [Test]
        public void TheConstructorShouldSetTheValuesCorrectly()
        {
            Assert.AreEqual(device.Brand, "Samsung");
            Assert.AreEqual(device.Price, 400);
            Assert.AreEqual(device.ScreenWidth, 28);
            Assert.AreEqual(device.ScreenHeigth, 16);
        }

        [Test]
        public void CurrentChannelShouldReturnTheCorrectChannel()
        {
            Assert.AreEqual(device.CurrentChannel, 0);
        }

        [Test]
        public void VolumeShouldReturnTheCorrectValue()
        {
            Assert.AreEqual(device.Volume, 13);
        }

        [Test]
        public void IsMutedShouldReturnTheCorrectValue()
        {
            Assert.AreEqual(device.IsMuted, false);
        }

        [Test]
        public void SwitchOnShouldReturnTheCorrectMessage()
        {
            string sound = "On";
            Assert.AreEqual(device.SwitchOn(), $"Cahnnel {device.CurrentChannel} - Volume {device.Volume} - Sound {sound}" );
            
        }

        [Test]
        public void ChangeChannelShouldWorkCorrectlyIfTheChannelIsOverZero()
        {
            Assert.AreEqual(device.ChangeChannel(5), 5);
        }

        [Test]
        public void ChangeChannelShouldThrowAnErrorIfTheChannelIsBelowZero()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                device.ChangeChannel(-12);
            });
        }

        [Test]
        public void IfTheDirectionIsUPLastVolumeShouldBeIncreased()
        {
            Assert.AreEqual(device.VolumeChange("UP", 10), $"Volume: 23");
        }

        [Test]
        public void IfTheDirectionIsUPTheLastVolumeShouldBeIncreasedNotMoreThan100()
        {
            Assert.AreEqual(device.VolumeChange("UP", 100), $"Volume: 100");
        }

        [Test]
        public void IfTheDirectionIsDOWNLastVolumeShouldBeDecreased()
        {
            Assert.AreEqual(device.VolumeChange("DOWN", 10), $"Volume: 3");
        }

        [Test]
        public void IfTheDirectionIsDOWNTheLastVolumeShouldBeDecreasedNotBelow0()
        {
            Assert.AreEqual(device.VolumeChange("DOWN", 100), $"Volume: 0");
        }

        [Test]
        public void IfIsMutedIsFalseMuteDeivceShouldMakeItTrue()
        {
            Assert.AreEqual(device.MuteDevice(), true);
        }

        [Test]
        public void ToStringMethodShouldWorkCorrectly()
        {
            Assert.AreEqual(device.ToString(), "TV Device: Samsung, Screen Resolution: 28x16, Price 400$");
        }

    }
}