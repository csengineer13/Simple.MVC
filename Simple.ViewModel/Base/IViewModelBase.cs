using System.Collections.Generic;
using Simple.ViewModel.Common;
using Simple.ViewModel.DTO;
using Simple.ViewModel.Interfaces;

namespace Simple.ViewModel.Base
{
	public interface IViewModelBase<Dto, DDto, TId>
		where Dto : class, IDto<TId>, new()
		where DDto : class, IDto<TId>, new()
	{
		List<Dto> List { get; set; } // List || Table
		SimpleModelState ModelState { get; set; }
		Dto Item { get; set; }		  
		DDto ItemDetail { get; set; } // Form || Selected
		List<ColumnData> Columns { get; }
		KOMapping KOMapping { get; set; }
		string ToJson();
		bool ItemDetailIsNew { get; set; }
		string Title { get; set; }
		LoggedInUserDTO User { get; set; }
		PageInfoDTO PageInfo { get; set; }

	}
}