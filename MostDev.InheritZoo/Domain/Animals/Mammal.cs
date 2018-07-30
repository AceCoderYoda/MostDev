#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.InheritZoo.Mammal.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace MostDev.InheritZoo.Domain.Animals
{
    public abstract class Mammal : Animal
    {
        protected Mammal()
        {
        }

        protected Mammal(int weight, string name = null)
            : base(weight, name)
        {
        }

        protected Mammal(int weight, DateTime date, string name = null)
            : base(weight, date, name)
        {
        }

        public int NumberOfChildernInWomb { get; set; }
    }
}