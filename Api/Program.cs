using Microsoft.Extensions.Hosting;

namespace Fritz.HatCollection.Api;

public class Program
{

	public static void Main()
	{

		var host = new HostBuilder()
			.ConfigureFunctionsWorkerDefaults()
			.Build();

		host.Run();

	}
}
