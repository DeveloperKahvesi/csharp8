using System;
using CSharp8.Demos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp8.Tests
{
	[TestClass]
	public class LocalFunctionTests
	{
		[TestMethod]
		public void ShouldReturnEven()
		{
			var lfDemo = new LocalFunctionDemo();
			var result = lfDemo.ShowOddOrEvent(2);
			Assert.IsTrue(result == "Even");
		}

		[TestMethod]
		public void ShouldReturnOdd()
		{
			var lfDemo = new LocalFunctionDemo();
			var result = lfDemo.ShowOddOrEvent(3);
			Assert.IsTrue(result == "Odd");
		}
	}
}
