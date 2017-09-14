using Abp.Application.Navigation;
using Abp.Localization;

namespace TreeView.WebSpaAngular
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See .cshtml and .js files under App/Main/views/layout/header to know how to render menu.
    /// </summary>
    public class TreeViewNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "TreeView",
                        new LocalizableString("TreeView", TreeViewConsts.LocalizationSourceName),
                        url: "#/treeview",
                        icon: "fa fa-asterisk"
                        )
                );
        }
    }
}
