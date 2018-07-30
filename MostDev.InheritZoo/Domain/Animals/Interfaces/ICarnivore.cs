#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.InheritZoo.ICarnivore.cs
// By            ::    Arjan Crielaard

#endregion

namespace MostDev.InheritZoo.Domain.Animals.Interfaces
{
    public interface ICarnivore : IAnimal
    {
        void EatMeat();
    }
}