using System;
using CSharp8.Demos;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CSharp8.Tests
{
	[TestClass]
	public class MyFileTests
	{

		[TestMethod]
		public void ShouldHaveHandleAfterOpened()
		{
			var f = new MyFile();
			f.Open();

			Assert.IsTrue(f.Handle != MyFile.NO_HANDLE);
		}

		[TestMethod]
		public void ShouldNotHaveHandleAfterClose()
		{
			var f = new MyFile();
			f.Open();
			f.Close();
			Assert.IsTrue(f.Handle == MyFile.NO_HANDLE);
		}

		[TestMethod]
		public void ShouldNotHaveHandleAfterDispose()
		{
			MyFile f;
			using (f = new MyFile())
			{
				f.Open();
			}

			Assert.IsTrue(f.Handle == MyFile.NO_HANDLE);
		}

		[TestMethod]
		public void ShouldHaveHandleBeforeDispose()
		{
			MyFile f;
			using (f = new MyFile())
			{
				f.Open();
				Assert.IsTrue(f.Handle != MyFile.NO_HANDLE);
			}
		}

		private MyFile MockCreateFile()
		{
			using var f = new MyFile();
			f.Open();
			return f;
		}

		[TestMethod]
		public void ShouldHaveNoHandleAfterExittingTheMethodScope()
		{

			var f = MockCreateFile();
			Assert.IsTrue(f.Handle == MyFile.NO_HANDLE);
		}
	}
}
