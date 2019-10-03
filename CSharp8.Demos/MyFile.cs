using System;

namespace CSharp8.Demos
{
	public class MyFile : IDisposable
	{
		public int Handle { get; private set; }

		public const int NO_HANDLE = -1;

		public int Open()
		{
			Handle = (new Random()).Next(0, Int16.MaxValue);
			return Handle;
		}

		public void Close()
		{
			Handle = NO_HANDLE;
		}

		private bool _isDisposing = false;
		public void Dispose()
		{
			if (_isDisposing || (Handle == NO_HANDLE) )
			{
				return;
			}
			_isDisposing = true;
			Handle = NO_HANDLE;
		}
	}
}
