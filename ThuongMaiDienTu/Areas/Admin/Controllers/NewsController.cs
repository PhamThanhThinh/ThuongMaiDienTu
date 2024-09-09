using Microsoft.AspNetCore.Mvc;

namespace ThuongMaiDienTu.Areas.Admin.Controllers
{
  [Area("Admin")]
  public class NewsController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
