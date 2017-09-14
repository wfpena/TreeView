using Abp.Web.Mvc.Views;

namespace TreeView.WebSpaAngular.Views
{
    public abstract class TreeViewWebViewPageBase : TreeViewWebViewPageBase<dynamic>
    {

    }

    public abstract class TreeViewWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected TreeViewWebViewPageBase()
        {
            LocalizationSourceName = "TreeView";
        }
    }
}