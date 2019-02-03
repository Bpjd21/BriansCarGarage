using System;
using Xunit;

namespace CarGarage.Tests
{
    public class GarageTests
    {
        [Fact]
        public void shouldAddCarToGarage()
        {
            // Tests AddCar() method
            var CarList = new Garage();
            // Arrange
            CarList.AddCar();
            // Act
            Assert.NotEmpty(CarList.myGarage);
            // Assert
        }

        [Fact]
        public void shouldRemoveCarFromGarage()
        {
            // Tests RemoveCar() method
            var CarList = new Garage();
            // Arrange
            CarList.RemoveCar();
            // Act
            Assert.Empty(CarList.myGarage);
            // Assert
        }

        [Fact]
        public void shouldFuelAllCars()
        {
            var CarList = new Garage();
            CarList.myGarage.Add(new Car());
            CarList.myGarage.Add(new Car());
            CarList.myGarage.Add(new Car());
            CarList.myGarage[0].Accelerate();
            CarList.myGarage[1].Accelerate();
            CarList.myGarage[2].Accelerate();
            CarList.FuelAllCars();
            Assert.Equal(100, CarList.myGarage[0].FuelLevel);

        }

        [Fact]
        public void shouldTestDriveOneCar()
        {
            // Use the Program class to let you select a single car
            // Program class should then let you choose what you want to do with that car
            // You do not need to test user input in the Program class
        }

        [Fact]
        public void youShouldNameThisTest()
        {
            // Should be able to list stats of all cars
            // Create necessary method(s)
            // Garage class should provide cars
            // Program class should list all stats
        }
    }
}
