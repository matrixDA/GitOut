using Microsoft.AspNetCore.Mvc;

namespace GitOut.Controllers
{
    public class Name : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult name()
        {
            string output = false ? "Dinesh Adhikari": "Dinesh Adhikari";

            return Json(output);
        }
    }
}
