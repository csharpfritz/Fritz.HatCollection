using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace Fritz.HatCollection.Api
{

	public class HatFunction
	{

		internal static IRepository Repository { get { return new StubRepository(); } }

		[FunctionName("GetHats")]
		public static IActionResult GetHats(
			[HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
			ILogger log)
		{

			var hats = Repository.GetHats();
			return new OkObjectResult(hats);

		}


		}

	}