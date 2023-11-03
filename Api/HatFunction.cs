using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace Fritz.HatCollection.Api;


public class HatFunction
{

	internal static IRepository Repository { get { return new AzureTableRepository(); } }

	[Function("GetHats")]
	public async Task<HttpResponseData> GetHats(
		[HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequestData req,
		ILogger log)
	{

		var hats = await Repository.GetHats();

		var response = req.CreateResponse(System.Net.HttpStatusCode.OK);
		await response.WriteAsJsonAsync(hats);

		return response;

	}


	}


