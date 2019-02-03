using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car
    {
        public int Speed { get; private set; }
        public int FuelLevel { get; private set; }
        public bool EngineOn { get; set; }
        
        public Car()
        {
            Speed = 0;
            FuelLevel = 100;
            EngineOn = true;

        }

        public Car(int startingFuelLevel)
        {
            Speed = 0;
            FuelLevel = startingFuelLevel;
            EngineOn = true;

        }

        public void Accelerate()
        {
            Speed += 10;
            FuelLevel -= 2;
        }

        public void AddFuel()
        {
            FuelLevel = 100;
        }

        public void Brake()
        {
            Speed -= 10;
            if (Speed < 0)
            {
                Speed += 10;
            }
                
        }

       
    }

    
}
