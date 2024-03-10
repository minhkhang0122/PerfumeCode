using Microsoft.AspNetCore.Mvc;

namespace BanHangMyPham.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
