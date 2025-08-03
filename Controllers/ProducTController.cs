using Microsoft.AspNetCore.Mvc;
using WebApplication_ForModel_To_Pass_Data_From_View_Controller.Models;

namespace WebApplication_ForModel_To_Pass_Data_From_View_Controller.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ShowData(ProductModel products)
        {
            ViewBag.name=products.Name;
            ViewBag.price=products.Price;
            ViewBag.description=products.Description;
            ViewBag.stock=products.Stock;
            ViewBag.category=products.Category;
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
