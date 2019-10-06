using System;
using System.Collections.Generic;

namespace CSharp8.Demos.DefaultInterfaceMembers
{
	public class Customer : ICustomer
	{
		public string Name { get; set; }
		public DateTime DateJoined { get; set; }
	}

	public class Product : IProduct
	{
		public string Name { get; set; }
		public decimal Price { get; set; }
	}

	public class Cart : ICart
	{
		public ICustomer Customer { get; private set; }
		public IEnumerable<ICartItem> Items { get; set; } = new List<ICartItem>();

		public Cart(ICustomer customer)
		{
			Customer = customer;
		}
	}

	public class CartItem : ICartItem
	{
		public IProduct Product { get; private set; }
		public int Amount { get; private set; }

		public CartItem(IProduct product, int amount)
		{
			Product = product;
			Amount = amount;
		}

		public decimal Discount()
		{
			if(Product.Price > 12000M)
			{
				return 0.20M;
			}
			else
			{
				return ICartItem.CaclulateDefaultDiscount(this);
			}
		}
	}
}
