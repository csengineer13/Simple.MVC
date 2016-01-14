using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using Humanizer;


/* This... Is a bunch of reflection (: */
namespace Simple.ViewModel.Common
{
	public class ViewModelMeta
	{
		public static List<ColumnData> GetColumns<T>(List<T> list)
		{
			var columns = new List<ColumnData>();
			var properties = typeof(T).GetProperties();
			foreach (var pi in properties)
			{
				var data = new ColumnData();
				data.DisplayName = GetDisplayName(pi);
				data.ColumnName = pi.Name;
				data.SortColumn = GetSortColumn(pi);
				data.DisableSort = IsSortDisabled(pi);
				//data.Format = GetFormat(pi);
				data.IsHidden = IsHidden(pi);

				columns.Add(data);
			}
			return columns;
		}

		public static string GetDisplayName(PropertyInfo pi)
		{
			var name = "";
			if (pi.IsDefined(typeof(DisplayAttribute), false))
			{
				name = pi.GetCustomAttributes(typeof(DisplayAttribute), false).Cast<DisplayAttribute>().Single().Name;
			}
			else
			{
				name = pi.Name.Humanize(LetterCasing.Title);
			}

			return name;
		}

		public static string GetSortColumn(PropertyInfo pi)
		{
			var sortColumn = pi.Name;

			if (pi.IsDefined(typeof(SortAttribute), false))
			{
				sortColumn = pi.GetCustomAttributes(typeof(SortAttribute), false).Cast<SortAttribute>().Single().ColumnOverride;
			}

			return sortColumn;
		}

		public static bool IsSortDisabled(PropertyInfo pi)
		{
			var sortDisabled = false;
			if (pi.IsDefined(typeof(SortAttribute), false))
			{
				sortDisabled = pi.GetCustomAttributes(typeof(SortAttribute), false).Cast<SortAttribute>().Single().DisableSort;
			}
			return sortDisabled;
		}

		public static bool IsHidden(PropertyInfo pi)
		{
			var hidden = false;
			if (pi.IsDefined(typeof(HiddenAttribute), false))
			{
				hidden = pi.GetCustomAttributes(typeof(HiddenAttribute), false).Cast<HiddenAttribute>().Single().Hidden;
			}
			return hidden;
		}
	}
}