using FaunaDB.Types;

namespace Fritz.HatCollection.Shared {

	public class Hat
	{

			[FaunaField("tag")]			
			public string Tag { get; set; }

			/// <summary>
			/// The human-readable name of the Hat in the collection
			/// </summary>
			/// <value></value>
			[FaunaField("name")]
			public string Name { get; set; }

			/// <summary>
			/// Brief description about the hat
			/// </summary>
			/// <value></value>
			[FaunaField("description")]
			public string Description { get; set; }

			[FaunaIgnore]
			public string ImageUrl { get; set; }

	}


}