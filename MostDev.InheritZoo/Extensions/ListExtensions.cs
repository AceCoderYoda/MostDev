#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.InheritZoo.ListExtensions.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.Collections.Generic;
using System.Linq;

#endregion

namespace MostDev.InheritZoo.Extensions
{
    public static class ListExtensions
    {
        public static int NumberOfMammals<T, TCheck>(this IList<T> list)
        {
            return list.OfType<TCheck>().Count();
        }
    }
}