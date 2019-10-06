using System;
namespace CSharp8.Demos
{
	public class LocalFunctionDemo
	{
		public string ShowOddOrEvent(int x)
		{
			static bool IsEven(int number)
			{
			 return number % 2 == 0;
			}

			return IsEven(x) ? "Even" : "Odd";
		}
	}
}
