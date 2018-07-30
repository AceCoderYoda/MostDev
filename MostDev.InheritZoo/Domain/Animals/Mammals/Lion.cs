#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.InheritZoo.Lion.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using MostDev.InheritZoo.Domain.Animals.Interfaces;
using MostDev.InheritZoo.Domain.Food.Interfaces;
using MostDev.InheritZoo.Extensions;

#endregion

namespace MostDev.InheritZoo.Domain.Animals.Mammals
{
    public class Lion : Mammal, ICarnivore
    {
        public Lion(int weight)
            : base(weight, "Lion")
        {
        }

        public override void Eat()
        {
            EatMeat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Rawrrrrrrrrr");
            SomeMethodInAnimal();
        }

        public void EatMeat()
        {
            GetFoodAndEat<IMeat>();

            if (IsHungry)
            {
                this.FightHerbivore();
                IsAlive = !IsHungry;
            }
        }
    }
}