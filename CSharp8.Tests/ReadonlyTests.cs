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

		[TestMethod]
		public void ShouldDescribe()
		{
			var p = new Point { X = 2, Y = 4 };
			var expectedResult = "My coordinates are (2,4)";
			var result = p.Describe();
			Assert.IsTrue(result == expectedResult);
		}

		[TestMethod]
		public void ShouldDescribeVerbatim()
		{
			var p = new Point { X = 2, Y = 4 };
			var expectedResult = @"My coordinates are:\r\n\t(2,4)";
			var result = p.DescribeVerbatim();
			Assert.IsTrue(result == expectedResult);
		}
	}
}
