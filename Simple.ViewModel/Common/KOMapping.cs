using System.Collections.Generic;
using System.Linq;

namespace Simple.ViewModel.Common
{
	public class KOMapping
	{
		public KOMapping()
		{
			// Always init lists in KO ;)
			ignore = new List<string>();	
			ignorePostBack = new List<string>();
			copy = new List<string>() { "KOMapping.copy", "Meta"}; // Forces meta to copy as non observable
		}

		public List<string> ignore { get; set; }
		public List<string> copy { get; set; }
		public List<string> ignorePostBack { get; set; }
		public List<string> allNonPostBack
		{
			get { return copy.Union(ignorePostBack).ToList();  }
		} 
	}
}