using System.Collections.Generic;
using Fritz.HatCollection.Shared;

namespace Fritz.HatCollection.Api
{
	public interface IRepository {

		IEnumerable<Hat> GetHats();

	}

}