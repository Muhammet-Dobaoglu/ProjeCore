using Microsoft.AspNetCore.Mvc;

namespace ProjeCore.Controllers
{
    public class LoginController : Controller
    {
  
        public IActionResult GirisYap()
        {
            return View();
        }
    }
}
