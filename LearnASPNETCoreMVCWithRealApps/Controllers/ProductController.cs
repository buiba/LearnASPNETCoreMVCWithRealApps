using LearnASPNETCoreMVCWithRealApps.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LearnASPNETCoreMVCWithRealApps.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        private DataContext db = new DataContext();

        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.products = db.Product.ToList();
            return View();
        }

        [Route("edit")]
        public IActionResult Edit()
        {
            return View();
        }
    }
}