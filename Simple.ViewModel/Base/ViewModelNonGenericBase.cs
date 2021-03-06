﻿using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using Simple.ViewModel.Common;
using Simple.ViewModel.DTO;

namespace Simple.ViewModel
{
	public abstract class ViewModelNonGenericBase
	{
		public ViewModelNonGenericBase()
		{
			ModelState = new SimpleModelState();
			KOMapping = new KOMapping();
			HasDialog = false;
			HasAlerts = true;
			Title = "";
			User = new LoggedInUserDTO();
			DefaultSammyRoute = "list";
			AllowEditing = true;
		}


		public abstract List<ColumnData> Columns { get; }

		//
		public bool HasAlerts { get; set; }
		public bool HasDialog { get; set; }
		public bool HasExport { get; set; }
		public bool ModalOpen { get; set; }
		public bool AllowEditing { get; set; }
		public bool IsLoading { get; set; }
		public bool IsRowLoading { get; set; }
		public bool IsTableLoading { get; set; }

		public string DefaultSammyRoute { get; set; }

		public KOMapping KOMapping { get; set; }
		public SimpleModelState ModelState { get; set; }
		public string Title { get; set; }
		public string FrontEndRoute { get; set; }
		public LoggedInUserDTO User { get; set; }

		// Quick Convert VM to JSON rep
		public string ToJson()
		{
			var json = JsonConvert.SerializeObject(this,
				Formatting.Indented,
				new JsonSerializerSettings
				{
					ReferenceLoopHandling = ReferenceLoopHandling.Ignore
				});

			return json;
		}
	}
}