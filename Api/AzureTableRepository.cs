using System.Collections.Generic;

using Fritz.HatCollection.Shared;
using System.Linq;
using System.Threading.Tasks;
using Azure.Data.Tables;

namespace Fritz.HatCollection.Api
{
	public class AzureTableRepository : IRepository
	{

		static readonly string CONN_STRING = System.Environment.GetEnvironmentVariable("AzureTableConnectionString");

		public async Task<IEnumerable<Hat>> GetHats()
		{
			var serviceClient = new TableServiceClient(CONN_STRING);
			var tableClient = serviceClient.GetTableClient("Hats");

			return tableClient.Query<Hat>(maxPerPage: 300).ToArray();

		}
	}

}
