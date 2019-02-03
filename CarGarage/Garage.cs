using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Garage
    {
        public List<Car> myGarage;

        public Garage()
        {
            myGarage = new List<Car>();
        }

        public void AddCar()
        {
            this.myGarage.Add(new Car());
        }

        public void RemoveCar()
        {
            this.myGarage.Remove(new Car());
        }

        public void FuelAllCars() //allcars
        {
            for (int i = 0; i < myGarage.Count; i++)
            {
                myGarage[i].AddFuel();
            }

        }

    }

    

}
