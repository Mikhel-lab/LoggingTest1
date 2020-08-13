using Microsoft.Extensions.Logging;
using System;

namespace LoggingTest1
{
	public class Myclass
	{

		private readonly ILogger _logger;
		public Myclass(ILogger<Myclass> logger)
		{
			_logger = logger;

		}
		internal void Run()
		{
			_logger.LogInformation("Application Started at {dateTime}", DateTime.UtcNow);

			//Business Logic START
			//Business logic END
			_logger.LogInformation("Application Ended at {dateTime}", DateTime.UtcNow);
		}

		//private readonly ILogger _logger;

		//public Myclass(ILogger<Myclass> logger)
		//{
		//	_logger = logger;
		//}

		//public void SomeMethod()
		//{
		//	_logger.LogInformation("Hello");
	}
	
}