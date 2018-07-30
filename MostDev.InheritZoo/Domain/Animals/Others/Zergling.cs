#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.InheritZoo.Zergling.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using MostDev.InheritZoo.Domain.Animals.Interfaces;
using MostDev.InheritZoo.Domain.Food.Interfaces;
using MostDev.InheritZoo.Extensions;

#endregion

namespace MostDev.InheritZoo.Domain.Animals.Others
{
    public class Terran : Mammal, ITerran
    {
        public override void Eat()
        {
            EatGrass();
        }

        public override void MakeSound()
        {
            Console.WriteLine("TIme to w/e");
        }

        public void EatGrass()
        {
            GetFoodAndEat<IPlant>();
        }
    }

    public class Zergling : Mammal, IZerg
    {
        public Zergling()
            : base(1, "For The Swarm")
        {
            NumberOfLegs = 4;
        }

        public int NumberOfClaws { get; set; } = 2;

        public override void Eat()
        {
            Console.WriteLine("Eating some nice 'Terran' skum");
            EatTerran();
        }

        public override void MakeSound()
        {
            Console.WriteLine("IYguywgeruywegr");
        }

        public void EatTerran()
        {
            this.EatActualTerran();
            IsAlive = !IsHungry;
        }
    }
}