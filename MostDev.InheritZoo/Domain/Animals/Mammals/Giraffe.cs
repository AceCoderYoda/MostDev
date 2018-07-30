#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.InheritZoo.Giraffe.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using MostDev.InheritZoo.Domain.Animals.Interfaces;
using MostDev.InheritZoo.Domain.Food.Interfaces;

#endregion

namespace MostDev.InheritZoo.Domain.Animals.Mammals
{
    public class Giraffe : Mammal, IHerbivore
    {
        public Giraffe(int weight)
            : base(weight, "Giraffe")
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Eating some 'trees'");
            EatGrass();
        }

        public override void MakeSound()
        {
            Console.WriteLine("uhm");
        }

        public void EatGrass()
        {
            GetFoodAndEat<IPlant>();
        }
    }
}