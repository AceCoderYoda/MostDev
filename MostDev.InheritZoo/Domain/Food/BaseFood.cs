#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.InheritZoo.BaseFood.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using MostDev.InheritZoo.Domain.Food.Interfaces;

#endregion

namespace MostDev.InheritZoo.Domain.Food
{
    public abstract class BaseFood : IFood
    {
        public string Name { get; set; }
        public float Amount { get; set; } = 10;
    }
}