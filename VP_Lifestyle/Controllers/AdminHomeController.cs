using VP_Lifestyle.Data;
using VP_Lifestyle.Models;
using VP_Lifestyle.Models.ProductMenuViewModel;
using Microsoft.AspNetCore.Mvc;

namespace VP_Lifestyle.Controllers
{
    public class AdminHomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
