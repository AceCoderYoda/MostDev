#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.Car.cs
// By            ::    Arjan Crielaard

#endregion

namespace MostDev
{
    public class Car
    {
        //private const int _maxSpeed = 184;
        private int maxSpeed = 184;

        //static CarT()
        //{
        //    _maxSpeed = 140;
        //}

        public Car()
        {
            Fuel = 40f;
        }

        public Car(float initialFuel, int maxSpeed)
        {
            Fuel = initialFuel;
            this.maxSpeed = maxSpeed;
        }
        //private static readonly int _maxSpeed = 184;

        public float Fuel { get; set; }

        ~Car()
        {
        }

        public void AddSomeFuel(float fuelToAdd)
        {
            if (fuelToAdd <= 0) throw new FuelNegativeException();
            Fuel += fuelToAdd;
            maxSpeed += 1;
            maxSpeed = maxSpeed + 1;
            maxSpeed--;
        }

        public static void CallSomethingOnCar()
        {
        }
    }
}