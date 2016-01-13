using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Simple.ViewModel.Common
{
	// todo: may need mechanism to differentiate text vs html data
	public class ColumnData
	{
		public ColumnData()
		{
		}

		public string DisplayName { get; set; }
		public string ColumnName { get; set; }
		public string SortColumn { get; set; }
		public bool DisableSort { get; set; }
		public bool IsHidden { get; set; }
		public bool IsSortedUp { get; set; }
		public bool IsSortedDown { get; set; }
}
}