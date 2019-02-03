using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car


    {
        public string Make { get; private set; }
        public string Model { get; private set; }
        public string Year { get; private set; }

        public List<Car> myGarage;
        
        public Car()
        {
            myGarage = new List<Car>();
        }
               
        public void AddCar()
        {
            myGarage.Add(new Car());
        }

        public void RemoveCar()
        {
            myGarage.Remove(new Car());
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
