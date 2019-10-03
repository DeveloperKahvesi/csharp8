using System;

namespace CSharp8.Demos
{
    public struct Point
    {
		public double X { get; set; }
		public double Y { get; set; }

		public string Tag { get; set; }

		public double Distance()
		{
			return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
		}

		public override string ToString()
		{
			return Tag + $"({X},{Y})";
		}
	}
}
