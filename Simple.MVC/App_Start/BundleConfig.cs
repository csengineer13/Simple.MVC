using System.Web.Optimization;

namespace Simple.MVC
{
	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			// JS
			bundles.Add(new ScriptBundle("~/bundles/vendor-and-toolkit-js")
				.Include("~/Scripts/vendor.js")
				.Include("~/Scripts/boostrap.min.js")
				);

			bundles.Add(new ScriptBundle("~/bundles/site-js")
				.Include("~/Scripts/app.js")
				.Include("~/Scripts/site.js")
				);


			// CSS
			bundles.Add(new StyleBundle("~/Content/bootstrap-css")
				.Include("~/Content/bootstrap.min.css")
				.Include("~/Content/bootstrap.min.css.map")
				);

			bundles.Add(new StyleBundle("~/Content/site-css")
				.Include("~/Content/css/site.css")
				);
		}
	}
}
