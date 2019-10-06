using System;
using System.Threading.Tasks;
using CSharp8.Demos;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CSharp8.Tests
{
	[TestClass]
	public class BatchDownloaderTests
	{
		[TestMethod]
		public async Task ShouldDownloadContentFromTwoSites()
		{
			var bd = new BatchDownloader();
			string[] urls = { "http://aliozgur.net","https://www.microsoft.com" };

			var results = await bd.DownloadAllAsync(urls);

			var totalLen = 0;
			foreach (var result in results)
			{
				totalLen += result.Length;
			}

			Assert.IsTrue(totalLen > 0);
		}

		[TestMethod]
		public async Task ShouldDownloadContentFromTwoSitesAsAsyncStream()
		{
			var bd = new BatchDownloader();
			string[] urls = { "http://aliozgur.net", "https://www.microsoft.com" };

			var results = bd.DownloadAllAsAsyncStream(urls);

			var totalLen = 0;

			await foreach (var result in results)
			{
				totalLen += result.Length;
			}

			Assert.IsTrue(totalLen > 0);
		}
	}
}
