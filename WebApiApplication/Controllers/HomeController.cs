#region

using System.Web.Mvc;

#endregion

namespace WebApiApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}