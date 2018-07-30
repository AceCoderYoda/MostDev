#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.AdvWeb.GenericTest.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using Microsoft.EntityFrameworkCore;

#endregion

namespace MostDev.AdvWeb.Services
{
    public interface IGenericTest<T>
    {
    }

    public class GenericTest<T> : IGenericTest<T>
        where T : DbContext
    {
        private DbContext _context;

        public GenericTest(T context)
        {
            _context = context;
        }
    }
}