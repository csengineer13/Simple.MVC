using System;
using System.Collections.Generic;
using Simple.ViewModel.Common;
using Simple.ViewModel.DTO;
using Simple.ViewModel.Interfaces;

namespace Simple.ViewModel.Base
{
	public abstract class ViewModelBase<Dto, DDto, TId> : ViewModelNonGenericBase, IViewModelBase<Dto, DDto, TId>
		where Dto : class, IDto<TId>, new()
		where DDto : class, IDto<TId>, new()
	{

		public ViewModelBase()
		{
			List = new List<Dto>();
			Item = new Dto();
			ItemDetail = new DDto();
			PageInfo = new PageInfoDTO();
		}

		public List<Dto> List { get; set; }
		public Dto Item { get; set; }
		public DDto ItemDetail { get; set; }
		public PageInfoDTO PageInfo { get; set; }
		public bool ItemDetailIsNew { get; set; }

		public override List<ColumnData> Columns
		{
			get
			{
				// todo: implement this
				//return ViewModelMeta.GetColumns(List);
				return new List<ColumnData>();
			}
		}

		public abstract TId GetDefaultIdValue();
	}
}