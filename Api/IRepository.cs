using System.Collections.Generic;
using System.Threading.Tasks;
using Fritz.HatCollection.Shared;

namespace Fritz.HatCollection.Api
{
	public interface IRepository {

		Task<IEnumerable<Hat>> GetHats();

	}

}
