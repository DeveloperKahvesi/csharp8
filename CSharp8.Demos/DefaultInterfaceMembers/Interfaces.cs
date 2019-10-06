using System;
using System.Collections.Generic;

namespace CSharp8.Demos.DefaultInterfaceMembers
{
	public interface ICustomer
	{
		string Name { get; set; }
		DateTime DateJoined { get; set; }

		public decimal LoyalityDiscount()
		{
			DateTime twoYearsAgo = DateTime.Now.AddYears(-2);
			DateTime threeYearsAgo = DateTime.Now.AddYears(-3);

			if(DateJoined <= threeYearsAgo)
			{
				return 0.15M;
			}
			else if(DateJoined <= twoYearsAgo)
			{
				return 0.10M;
			}
			else
				return 0m;
		}
	}

	public interface IProduct
	{
		string Name { get; set; }
		decimal Price { get; set; }
	}

	public interface ICart
	{
		ICustomer Customer { get;}
		IEnumerable<ICartItem> Items { get; set; }
		public decimal TotalDiscount()
		{
			return 0M;
		}
	}
	

	public interface ICartItem
	{
		IProduct Product { get; }
		int Amount { get; }

		private static int _defaultDiscountAmount = 3;
		private static decimal _defaultDiscountPercent = 0.10M;

		public static void SetDefaultDiscountAmount(int discountAmount, decimal discountPercent)
		{
			_defaultDiscountAmount = discountAmount;
			_defaultDiscountPercent = discountPercent;
		}

		public decimal Discount() => CaclulateDefaultDiscount(this);

		protected static decimal CaclulateDefaultDiscount(ICartItem ci)
		{
			if (ci.Amount > _defaultDiscountAmount)
			{
				return _defaultDiscountPercent;
			}
			else
			{
				return 0M;
			}
		}
	}
}
