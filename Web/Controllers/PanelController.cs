using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PanelController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}