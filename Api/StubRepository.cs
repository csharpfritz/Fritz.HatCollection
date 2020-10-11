using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fritz.HatCollection.Shared;


namespace Fritz.HatCollection.Api
{
    public class StubRepository : IRepository {

		public Task<IEnumerable<Hat>> GetHats() {

			return Task.FromResult(new Hat[] {
				new Hat {
					Tag="vegas_knights",
					RawName="Las Vegas Golden Knights",
					Description="Fritz got this hat when he last visited Las Vegas in 2019 and attended a Golden Knights hockey game."
				}
			}.AsEnumerable());

		}

	}

}
