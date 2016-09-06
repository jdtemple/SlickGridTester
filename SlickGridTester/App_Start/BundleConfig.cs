using System.Web;
using System.Web.Optimization;

namespace SlickGridTester
{
  public class BundleConfig
  {
    // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
    public static void RegisterBundles(BundleCollection bundles)
    {
      //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
      //            "~/Scripts/jquery-{version}.js"));

      //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
      //            "~/Scripts/jquery.validate*"));

      //// Use the development version of Modernizr to develop with and learn from. Then, when you're
      //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
      //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
      //            "~/Scripts/modernizr-*"));

      //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
      //          "~/Scripts/bootstrap.js",
      //          "~/Scripts/respond.js"));

      //bundles.Add(new StyleBundle("~/Content/css").Include(
      //          "~/Content/bootstrap.css",
      //          "~/Content/site.css"));

      //_Layout.cshtml
      bundles.Add(new StyleBundle("~/content/layout")
        .Include("~/Content/bootstrap.css")
        .Include("~/Content/bootstrap-theme.css")
        .Include("~/Content/bootstrap-datetimepicker*")
        .Include("~/Content/site.css")
        .Include("~/Content/slick.grid*")
        .Include("~/Content/slick.pager*")
        .Include("~/Content/slick.columnpicker*")
        .Include("~/Content/slick.headerbuttons*")
        .Include("~/Content/slick.headermenu*")
        .Include("~/Content/slick-default-theme*")
        );

      bundles.Add(new ScriptBundle("~/bundles/layout")
        .Include("~/Scripts/modernizr-*")
        .Include("~/Scripts/jquery-{version}.js")
        .Include("~/Scripts/jquery.validate*")
        .Include("~/Scripts/jquery.easing.{version}.js")
        .Include("~/Scripts/jquery.globalize.min.js")
        .Include("~/Scripts/jquery-ui-{version}.js")
        .Include("~/Scripts/jsrender.min.js")
        .Include("~/Scripts/respond*")
        .Include("~/Scripts/jquery-ui.sortable*")
        .Include("~/Scripts/jquery.event.drag*")
        .Include("~/Scripts/SlickGrid/slick.core*")
        .Include("~/Scripts/SlickGrid/slick.formatters*")
        .Include("~/Scripts/SlickGrid/slick.editors*")
        .Include("~/Scripts/SlickGrid/slick.grid*")
        .Include("~/Scripts/SlickGrid/slick.groupitemmetadataprovider*")
        .Include("~/Scripts/SlickGrid/slick.dataview*")
        .Include("~/Scripts/SlickGrid/Plugins/slick.cellrangedecorator*")
        .Include("~/Scripts/SlickGrid/Plugins/slick.cellrangeselector*")
        .Include("~/Scripts/SlickGrid/Plugins/slick.cellselectionmodel*")
        .Include("~/Scripts/SlickGrid/Controls/slick.pager*")
        .Include("~/Scripts/SlickGrid/Controls/slick.columnpicker*")
        .Include("~/Scripts/SlickGrid/Plugins/slick.checkboxselectcolumn*")
        );
    }
  }
}
