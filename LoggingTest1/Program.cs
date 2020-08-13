using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace LoggingTest1
{
	class Program
	{
		

		static void Main(string[] args)
		{
			var services = new ServiceCollection();
			ConfigureServices(services);
			using (ServiceProvider serviceProvider = services.BuildServiceProvider())
			{
				Myclass app = serviceProvider.GetService<Myclass>();
				// Start up logic here
				app.Run();
			}
		}
		private static void ConfigureServices(ServiceCollection services)
		{
			services.AddLogging(configure => configure.AddConsole())
			.AddTransient<Myclass>();
		}
	}
}
