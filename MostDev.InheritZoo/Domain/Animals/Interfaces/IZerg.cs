#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.InheritZoo.IZerg.cs
// By            ::    Arjan Crielaard

#endregion

namespace MostDev.InheritZoo.Domain.Animals.Interfaces
{
    public interface IZerg : IAnimal
    {
        void EatTerran();
    }
}