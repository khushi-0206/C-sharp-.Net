using AuthenticationDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationDemo.Controllers
{
    public class ProductController : Controller
    {
        ProductRepo prodRepo = null;
        public ProductController()
        {
            prodRepo = new ProductRepo();
        }
        [Route("")]
        [Route("Cosmetics")]
        [Route("Products/BeautyCare")]
        public IActionResult Index1()
        {
            return View(prodRepo.GetAllCosmeticProducts());
        }
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult Index3()
        {
            return View();
        }
    }
}
