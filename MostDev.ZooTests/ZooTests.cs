#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.ZooTests.ZooTests.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using Microsoft.VisualStudio.TestTools.UnitTesting;
using MostDev.InheritZoo.Business;

#endregion

namespace MostDev.ZooTests
{
    [TestClass]
    public class ZooTests
    {
        [TestMethod]
        public void CreateAndCheckZoo()
        {
            var zoo = Zoo.Instance();

            Assert.AreEqual(zoo.GetNumberOfAnimals(), 0);

            zoo.FillZoo();
            Assert.AreEqual(zoo.GetNumberOfAnimals(), 5);
        }
    }
}