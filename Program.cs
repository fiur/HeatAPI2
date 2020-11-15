using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace React.Sample.Webpack.CoreMvc
{
	public class Program
	{
		public static void Main(string[] args)
		{
			BuildWebHost(args).Run();
		}

		public static IWebHost BuildWebHost(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseUrls("http://localhost:60000", "http://localhost:60001", "http://localhost:9457", "http://varmepumpe.local")
				.UseStartup<Startup>()
				.Build();
	}
}
