#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.InheritZoo.IFood.cs
// By            ::    Arjan Crielaard

#endregion

namespace MostDev.InheritZoo.Domain.Food.Interfaces
{
    public interface IFood
    {
        string Name { get; set; }
        float Amount { get; set; }
    }
}