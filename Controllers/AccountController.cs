using Microsoft.AspNetCore.Mvc;

namespace POE_MVC_Part_1.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        public IActionResult Login(string username, string password, string role)
        {
            // No authentication, just role-based redirection
            ViewBag.Username = username;
            ViewBag.Role = role;

            if (role == "Lecturer")
            {
                return RedirectToAction("Lecturer");
            }
            else if (role == "PC")
            {
                return RedirectToAction("ProgramCoordinator");
            }
            else if (role == "PM")
            {
                return RedirectToAction("ProgramManager");
            }

            return View();
        }

        // Lecturer Dashboard
        public IActionResult Lecturer()
        {
            return View();
        }

        // Program Coordinator Dashboard
        public IActionResult ProgramCoordinator()
        {
            return View();
        }

        // Program Manager Dashboard
        public IActionResult ProgramManager()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string fullname, string email, string username, string password, string role)
        {
            // Simulated registration
            ViewBag.FullName = fullname;
            ViewBag.Email = email;
            ViewBag.Username = username;
            ViewBag.Role = role;

            // Redirect to login
            return RedirectToAction("Login");
        }

        // Logout
        public IActionResult Logout()
        {
            return View();
        }
    }
}
