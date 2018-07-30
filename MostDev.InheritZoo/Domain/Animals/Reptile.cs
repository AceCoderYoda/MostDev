#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.InheritZoo.Reptile.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace MostDev.InheritZoo.Domain.Animals
{
    public abstract class Reptile : Animal
    {
        protected Reptile()
        {
        }

        protected Reptile(int weight, string name = null)
            : base(weight, name)
        {
        }

        protected Reptile(int weight, DateTime date, string name = null)
            : base(weight, date, name)
        {
        }

        public int NumberOfEggs { get; set; }
    }
}