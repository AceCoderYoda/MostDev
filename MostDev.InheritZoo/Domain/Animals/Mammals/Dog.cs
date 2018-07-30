#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.InheritZoo.Dog.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using MostDev.InheritZoo.Domain.Animals.Interfaces;
using MostDev.InheritZoo.Domain.Food.Interfaces;

#endregion

namespace MostDev.InheritZoo.Domain.Animals.Mammals
{
    public class Dog : Mammal, ICarnivore
    {
        public Dog(int weight)
            : base(weight, "Yes, this is Dog?")
        {
        }

        public override void Eat()
        {
            EatMeat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woef");
        }

        public void EatMeat()
        {
            GetFoodAndEat<IMeat>();
            IsAlive = !IsHungry;
        }
    }
}