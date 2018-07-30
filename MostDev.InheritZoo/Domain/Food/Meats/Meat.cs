#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.InheritZoo.Meat.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using MostDev.InheritZoo.Domain.Food.Interfaces;

#endregion

namespace MostDev.InheritZoo.Domain.Food.Meats
{
    public class Meat : BaseFood, IMeat
    {
    }
}