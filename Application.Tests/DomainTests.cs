using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Application.Tests
{
	[TestClass]
	public class DomainTests
	{
		[TestMethod]
		public void Hero_SetsHeroClassOk()
		{
			var cut = new Hero("Hunter");
			Assert.IsTrue(cut.HeroClass.Equals(HeroClass.Hunter));
		}
	}
}
