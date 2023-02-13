using BlogSite.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BlogSite.Controllers
{
    public class LoginController : Controller
    {
        private readonly DatabaseContext _context;

        public LoginController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(string email, string password)
        {
            try
            {
                var user = _context.Users.FirstOrDefault(x => x.Email == email && x.Password == password && x.IsActive);
                if (user == null)
                {
                    TempData["Message"] = "Log in failed";
                } else
                {
                    var userLaw = new List<Claim>() { new Claim(ClaimTypes.Email, user.Email) };
                    var userID = new ClaimsIdentity(userLaw, "Login");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(userID);
                    await HttpContext.SignInAsync(claimsPrincipal);
                    if (user.IsAdmin)
                    {
                        return Redirect("/Admin");
                    }
                     else
                    {
                        return Redirect("/Home");
                    }
                }
            }
            catch (Exception err)
            {
                TempData["Message"] = "Error";
            }
            return View();
        }

        [Route("LogOut")]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/Home");
        }
    }
}
