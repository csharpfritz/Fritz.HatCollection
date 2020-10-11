using FaunaDB.Types;

namespace Fritz.HatCollection.Shared {

	public class Hat
	{

			[FaunaConstructor]
			public Hat(string tag, string name, string description)
			{
					this.Tag = tag;
					this.RawName = name;
					this.Description = description;
			}

			public Hat() {}

			[FaunaField("tag")]			
			public string Tag { get; set; }

			/// <summary>
			/// The human-readable name of the Hat in the collection
			/// </summary>
			/// <value></value>
			[FaunaField("name")]
			public string RawName {  get; set; }

			public string Name {
				get { return string.IsNullOrEmpty(RawName) ? Tag : RawName; }
			}

			/// <summary>
			/// Brief description about the hat
			/// </summary>
			/// <value></value>
			[FaunaField("description")]
			public string Description { get; set; }

			[FaunaIgnore]
			public string ImageUrl { get; set; }

		public override string ToString()
		{
			return $"Tag: {Tag}, Name: {Name}, Desc: {Description}";
		}

	}


}
