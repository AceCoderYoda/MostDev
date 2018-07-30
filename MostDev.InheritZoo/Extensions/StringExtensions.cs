#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.InheritZoo.StringExtensions.cs
// By            ::    Arjan Crielaard

#endregion

namespace MostDev.InheritZoo.Extensions
{
    public static class StringExtensions
    {
        public static int NumberOfWords(this string str)
        {
            return str.Split(" ").Length;
        }
    }
}