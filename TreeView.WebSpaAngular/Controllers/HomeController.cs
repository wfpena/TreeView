using System.Web.Mvc;

namespace TreeView.WebSpaAngular.Controllers
{
    public class HomeController : TreeViewControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}