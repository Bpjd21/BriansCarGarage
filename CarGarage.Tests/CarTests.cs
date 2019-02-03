using System;
using Xunit;

namespace CarGarage.Tests
{
    public class CarTests
    {
        [Fact]
        public void shouldAccelerate()
        {
            // Tests Accelerate() method in Car increases Speed
            var firstCar = new Car();
            // Arrange
            firstCar.Accelerate();
            // Act
            Assert.Equal(10, firstCar.Speed);
            // Assert
        }

        [Fact]
        public void shouldConsumeFuel()
        {
            // Tests Accelerate() method reduces Fuel amount
            var firstCar = new Car();
            // Arrange
            firstCar.Accelerate();
            // Act
            Assert.Equal(98, firstCar.FuelLevel);
            // Assert
        }

        [Fact]
        public void shouldRefuel()
        {
            // Tests AddFuel() method increases Fuel amount
            var firstCar = new Car(80);
            // Arrange
            firstCar.AddFuel();
            // Act
            Assert.Equal(100, firstCar.FuelLevel);
            // Assert
        }

        [Fact]
        public void shouldSlowDown()
        {
            // Tests Brake() method in Car reduces Speed amount
            var firstCar = new Car();
            // Arrange
            firstCar.Brake();
            // Act
            Assert.Equal(0, firstCar.Speed);
            // Assert
        }

        [Fact]
        public void shouldStart()
        {
            // Tests ToggleEngine() method starts car when its off
            // Arrange
            // Act
            // Assert
        }

        [Fact]
        public void shouldTurnOff()
        {
            // Tests ToggleEngine() method turns car off when its on
            // Arrange
            // Act
            // Assert
        }
    }
}
