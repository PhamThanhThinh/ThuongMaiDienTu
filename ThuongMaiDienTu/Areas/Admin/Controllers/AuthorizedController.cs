using Microsoft.AspNetCore.Mvc;

namespace ThuongMaiDienTu.Areas.Admin.Controllers
{
  public class AuthorizedController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
