#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.InheritZoo.Animal.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using MostDev.InheritZoo.Business;
using MostDev.InheritZoo.Domain.Animals.Interfaces;
using MostDev.InheritZoo.Domain.Food.Interfaces;

#endregion

namespace MostDev.InheritZoo.Domain.Animals
{
    public abstract class Animal : IAnimal
    {
        protected Animal()
        {
        }

        protected Animal(int weight, string name = null)
            : this(weight, DateTime.Now, name)
        {
        }

        protected Animal(int weight, DateTime date, string name = null)
        {
            Weight = weight;
            Name = name;
            Date = date;
        }

        public int NumberOfLegs { get; set; } = 4;
        public DateTime Date { get; set; } = DateTime.Now;

        public float AmountOfFoodWhenEating => Weight / 2.5f;

        public string Name { get; set; }
        public int Weight { get; set; }
        public bool IsHungry { get; set; }
        public bool IsAlive { get; set; } = true;

        public abstract void Eat();
        public abstract void MakeSound();

        protected void SomeMethodInAnimal()
        {
            Console.WriteLine("Some Method in Animal");
        }

        protected void GetFoodAndEat<T>()
            where T : IFood
        {
            if (Zoo.Instance().GetFood<T>(AmountOfFoodWhenEating))
                IsHungry = false;
            else
                IsHungry = true;
        }
    }
}