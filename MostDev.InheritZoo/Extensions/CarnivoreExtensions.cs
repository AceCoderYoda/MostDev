#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.InheritZoo.CarnivoreExtensions.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using MostDev.InheritZoo.Business;
using MostDev.InheritZoo.Domain.Animals.Interfaces;

#endregion

namespace MostDev.InheritZoo.Extensions
{
    public static class CarnivoreExtensions
    {
        public static bool FightHerbivore(this ICarnivore carnivore)
        {
            var herbivore = Zoo.Instance().FindHerbivore();

            if (herbivore != null)
            {
                Console.WriteLine($"{carnivore.Name} ate {herbivore.Name}");
                carnivore.IsHungry = false;
                return true;
            }

            return false;
        }
    }
}