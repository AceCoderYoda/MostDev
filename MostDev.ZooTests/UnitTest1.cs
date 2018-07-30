#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.ZooTests.UnitTest1.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace MostDev.ZooTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 1, y = 2;

            Assert.IsFalse(x == y);
        }
    }
}