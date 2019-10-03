using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CSharp8.Demos;

namespace CSharp8.Tests
{
    [TestClass]
    public class ReadonlyTests
    {
        [TestMethod]
        public void NoModifierTest()
        {
			var p = new Point
			{
				X = 3,
				Y = 4,
			};

			var result = p.Distance();
			var expectedResult = 5;

			Assert.AreEqual(result,expectedResult);
		}

		[TestMethod]
		public void ReadonlyModifierTest()
		{
			var p = new Point
			{
				X = 3,
				Y = 4,
				Tag = "P1"
			};

			var expectedResult = $"P1(3,4)";
			Assert.IsTrue(expectedResult == p.ToString());
		}
	}
}
