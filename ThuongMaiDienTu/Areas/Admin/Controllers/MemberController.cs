using Microsoft.AspNetCore.Mvc;

namespace ThuongMaiDienTu.Areas.Admin.Controllers
{
  [Area("Admin")]
  public class MemberController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Login()
    {
      return View();
    }
  }
}
