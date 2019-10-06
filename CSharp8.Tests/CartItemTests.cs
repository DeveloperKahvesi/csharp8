using System;
using CSharp8.Demos.DefaultInterfaceMembers;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CSharp8.Tests
{
	[TestClass]
	public class CartItemTests
	{
		[TestMethod]
		public void ShouldHaveTenPercentDiscount()
		{
			var cartItem = new CartItem(new Product { Name = "iPhone X", Price = 12000M }, 4);
			ICartItem ci = cartItem;
			var discount = ci.Discount();
			Assert.IsTrue(discount  == 0.10M);
		}

		[TestMethod]
		public void ShouldHaveZeroDiscount()
		{
			var cartItem = new CartItem(new Product { Name = "iPhone X", Price = 12000M }, 2);
			ICartItem ci = cartItem;
			var discount = ci.Discount();
			Assert.IsTrue(discount == 0);
		}

		[TestMethod]
		public void ShouldHaveTenPercentDiscountWhenAmountIsGreaterThanFive()
		{
			var cartItem = new CartItem(new Product { Name = "iPhone X", Price = 12000M }, 3);

			ICartItem.SetDefaultDiscountAmount(2,0.10M);

			ICartItem ci = cartItem;
			var discount = ci.Discount();
			Assert.IsTrue(discount == 0.10M);
		}

		[TestMethod]
		public void ShouldHaveFifteenPercentDiscountWhenAmountIsGreaterThanFive()
		{
			var cartItem = new CartItem(new Product { Name = "iPhone X", Price = 12000M }, 3);

			ICartItem.SetDefaultDiscountAmount(2, 0.15M);

			ICartItem ci = cartItem;
			var discount = ci.Discount();
			Assert.IsTrue(discount == 0.15M);
		}

		[TestMethod]
		public void ShouldHaveTwentyPercentDiscount()
		{
			var cartItem = new CartItem(new Product { Name = "LG 4K TV", Price = 16000M }, 3);

			ICartItem.SetDefaultDiscountAmount(2, 0.15M);

			ICartItem ci = cartItem;
			var discount = ci.Discount();
			Assert.IsTrue(discount == 0.20M);
		}

		[TestMethod]
		public void ShouldApplyDefaultDiscount()
		{
			var cartItem = new CartItem(new Product { Name = "Samsun A70", Price = 10000M }, 3);

			ICartItem.SetDefaultDiscountAmount(2, 0.15M);

			ICartItem ci = cartItem;
			var discount = ci.Discount();
			Assert.IsTrue(discount == 0.15M);
		}
	}
}
