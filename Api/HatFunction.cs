using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace Fritz.HatCollection.Api
{

	public class HatFunction
	{

		internal static IRepository Repository { get { return new AzureTableRepository(); } }

		[FunctionName("GetHats")]
		public static async Task<IActionResult> GetHats(
			[HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
			ILogger log)
		{

			var hats = await Repository.GetHats();
			return new OkObjectResult(hats);

		}


		}

	}
