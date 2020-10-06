using System.Collections.Generic;
using FaunaDB.Client;
using static FaunaDB.Query.Language;
using static FaunaDB.Types.Option;
using static FaunaDB.Types.Encoder;
using FaunaDB.Types;

using Fritz.HatCollection.Shared;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Fritz.HatCollection.Api
{
	public class FaunaRepository : IRepository
	{

		static readonly string ENDPOINT = "https://db.fauna.com:443";
		static readonly string SECRET = System.Environment.GetEnvironmentVariable("FaunaKey");

		public async Task<IEnumerable<Hat>> GetHats()
		{

			var client = new FaunaClient(endpoint: ENDPOINT, secret: SECRET);
			var result = client.Query(Paginate(Collection("hats"))).GetAwaiter().GetResult();

			// Console.WriteLine(result.At("data").To<Hat[]>().Value.Length);
			Console.WriteLine(result.At("data"));

			var hats = result.At("data").To<Hat[]>().Value;
			return hats;
		}
	}

}
