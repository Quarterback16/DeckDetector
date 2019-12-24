using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Application.Tests
{
    [TestClass]
    public class HearthDbTests
    {

        [TestMethod]
        public void ManaCostForNorthshireCleric_Returns_1()
        {
            Assert.AreEqual(
				expected: 1, 
				actual: HearthDb.ManaCost("Northshire Cleric"));
        }

        [TestMethod]
        public void ManaCostForDragonbane_Returns_4()
        {
            Assert.AreEqual(
                expected: 4,
                actual: HearthDb.ManaCost("Dragonbane"));
        }
    }
}
