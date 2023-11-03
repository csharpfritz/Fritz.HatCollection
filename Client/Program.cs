using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorApp.Client;

public class Program
{

	public const string BaseImageUrl = "https://hatcollection.blob.core.windows.net/hat-images";

	public static async Task Main(string[] args)
	{
		var builder = WebAssemblyHostBuilder.CreateDefault(args);
		builder.RootComponents.Add<App>("app");
		builder.RootComponents.Add<HeadOutlet>("head::after");


		var baseAddress = builder.Configuration["BaseAddress"] ?? builder.HostEnvironment.BaseAddress;
		builder.Services.AddScoped(_ => new HttpClient { BaseAddress = new Uri(baseAddress) });

		await builder.Build().RunAsync();
	}

}
