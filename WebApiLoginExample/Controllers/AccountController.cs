using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiLoginExample.Models;

namespace WebApiLoginExample.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public IActionResult Register(UserRegisterModel user)
        {
            return Ok(user);
        }
    }
}