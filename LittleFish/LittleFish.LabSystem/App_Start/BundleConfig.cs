using System.Web;
using System.Web.Optimization;

namespace LittleFish.LabSystem
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.validate.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/jui").Include(
                "~/Scripts/jui/js/dwz.core.js",
                "~/Scripts/jui/js/dwz.util.date.js",
                "~/Scripts/jui/js/dwz.validate.method.js",
                "~/Scripts/jui/js/dwz.barDrag.js",
                "~/Scripts/jui/js/dwz.drag.js",
                "~/Scripts/jui/js/dwz.tree.js",
                "~/Scripts/jui/js/dwz.accordion.js",
                "~/Scripts/jui/js/dwz.ui.js",
                "~/Scripts/jui/js/dwz.theme.js",
                "~/Scripts/jui/js/dwz.switchEnv.js",
                "~/Scripts/jui/js/dwz.alertMsg.js",
                "~/Scripts/jui/js/dwz.contextmenu.js",
                "~/Scripts/jui/js/dwz.navTab.js",
                "~/Scripts/jui/js/dwz.tab.js",
                "~/Scripts/jui/js/dwz.resize.js",
                "~/Scripts/jui/js/dwz.dialog.js",
                "~/Scripts/jui/js/dwz.dialogDrag.js",
                "~/Scripts/jui/js/dwz.sortDrag.js",
                "~/Scripts/jui/js/dwz.cssTable.js",
                "~/Scripts/jui/js/dwz.stable.js",
                "~/Scripts/jui/js/dwz.taskBar.js",
                "~/Scripts/jui/js/dwz.ajax.js",
                "~/Scripts/jui/js/dwz.pagination.js",
                "~/Scripts/jui/js/dwz.datebase.js",
                "~/Scripts/jui/js/dwz.datepicker.js",
                "~/Scripts/jui/js/dwz.effects.js",
                "~/Scripts/jui/js/dwz.panel.js",
                "~/Scripts/jui/js/dwz.checkbox.js",
                "~/Scripts/jui/js/dwz.history.js",
                "~/Scripts/jui/js/dwz.combox.js",
                "~/Scripts/jui/js/dwz.file.js",
                "~/Scripts/jui/js/dwz.print.js",
                "~/Scripts/jui/js/dwz.regional.zh.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css"));
        }
    }
}
