#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.InheritZoo.IHerbivore.cs
// By            ::    Arjan Crielaard

#endregion

namespace MostDev.InheritZoo.Domain.Animals.Interfaces
{
    public interface IHerbivore : IAnimal
    {
        void EatGrass();
    }
}