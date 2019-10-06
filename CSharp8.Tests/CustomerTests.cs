using System;
using CSharp8.Demos.DefaultInterfaceMembers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp8.Tests
{
	[TestClass]
	public class CustomerTests
	{
		[TestMethod]
		public void ShouldHaveTenPercentDiscount()
		{
			var customer = new Customer
			{
				Name = "Ali Özgür",
				DateJoined = DateTime.Now.AddYears(-2)
			};

			ICustomer c = customer;
			var result = c.LoyalityDiscount();
			Assert.IsTrue(result == 0.10M);
		}

		[TestMethod]
		public void ShouldHaveFifteenPercentDiscount()
		{
			var customer = new Customer
			{
				Name = "Ali Özgür",
				DateJoined = DateTime.Now.AddYears(-4)
			};

			ICustomer c = customer;
			var result = c.LoyalityDiscount();
			Assert.IsTrue(result == 0.15M);
		}
	}
}
