using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp8.Demos
{
	public class BatchDownloader
	{
		public Task<string> DownloadAsync(string url)
		{
			var client = new HttpClient();
			return client.GetStringAsync(url);
		}

		public Task<string[]> DownloadAllAsync(string[] urls)
		{
			var tasks = urls.Select(url => DownloadAsync(url));
			return Task.WhenAll(tasks);
		}

		public async IAsyncEnumerable<string> DownloadAllAsAsyncStream(string[] urls)
		{
			foreach(var url in urls)
			{
				var result = await DownloadAsync(url);
				yield return result;
			}
		}
	}
}
