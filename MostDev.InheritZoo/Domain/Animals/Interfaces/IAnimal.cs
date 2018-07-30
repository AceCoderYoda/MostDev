#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.InheritZoo.IAnimal.cs
// By            ::    Arjan Crielaard

#endregion

namespace MostDev.InheritZoo.Domain.Animals.Interfaces
{
    public interface IAnimal
    {
        bool IsHungry { get; set; }
        bool IsAlive { get; set; }
        string Name { get; set; }
        int Weight { get; set; }

        void Eat();
        void MakeSound();
    }
}