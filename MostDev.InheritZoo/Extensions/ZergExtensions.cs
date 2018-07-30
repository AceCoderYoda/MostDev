#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.InheritZoo.ZergExtensions.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using MostDev.InheritZoo.Business;
using MostDev.InheritZoo.Domain.Animals.Interfaces;

#endregion

namespace MostDev.InheritZoo.Extensions
{
    public static class ZergExtensions
    {
        public static bool EatActualTerran(this IZerg zerg)
        {
            var terran = Zoo.Instance().Find<ITerran>();

            if (terran != null)
            {
                Console.WriteLine($"{zerg.Name} ate {terran.Name}");
                zerg.IsHungry = false;
                return true;
            }

            zerg.IsHungry = true;

            return false;
        }
    }
}