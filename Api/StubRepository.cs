using System.Collections.Generic;
using Fritz.HatCollection.Shared;


namespace Fritz.HatCollection.Api
{
	public class StubRepository : IRepository {
		
		public IEnumerable<Hat> GetHats() {
			
			return new Hat[] {
				new Hat {
					Tag="vegas_knights",
					Name="Las Vegas Golden Knights",
					Description="Fritz got this hat when he last visited Las Vegas in 2019 and attended a Golden Knights hockey game."
				}
			};
			
		}

	}

}