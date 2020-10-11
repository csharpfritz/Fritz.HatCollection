using System;

namespace Fritz.HatCollection.Client.Models {

	public class SearchArgs : EventArgs {

		public SearchArgs(string term)
		{
				this.SearchTerm = term;
		}

		public string SearchTerm { get; set; }

	}


}