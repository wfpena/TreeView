using Abp.Web.Mvc.Controllers;

namespace TreeView.WebSpaAngular.Controllers
{
    public abstract class TreeViewControllerBase : AbpController
    {
        protected TreeViewControllerBase()
        {
            LocalizationSourceName = "TreeView";
        }
    }
}