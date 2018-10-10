using Microsoft.VisualStudio.TestTools.UnitTesting;

using Library;

namespace TestLibrary
{
    [TestClass]
    public class LibraryTests
    {
        [TestMethod]
        public void ThingGetsObjectValFromNumber()
        {
            Assert.AreEqual(42, new Thing().Get(42));
        }
    }
}
