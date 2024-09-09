using Microsoft.AspNetCore.Mvc;

namespace ThuongMaiDienTu.Controllers
{
  public class CategoryController : Controller
  {


    public IActionResult Index()
    {
      return View();
    }
  }
}
