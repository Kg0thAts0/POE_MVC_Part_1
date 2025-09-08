using Microsoft.AspNetCore.Mvc;

namespace POE_MVC_Part_1.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index(string role = "Lecturer")
        {
            // Fake data (in a real app this would come from DB)
            ViewBag.Role = role;
            ViewBag.Claims = new[]
            {
                new { Month = "January", Lecturer = "Mr. Magwaza", Hours = 20, Rate = 200, Total = 4000, Status = "Approved" },
                new { Month = "February", Lecturer = "Ms. Radebe", Hours = 25, Rate = 220, Total = 5500, Status = "Pending" },
                new { Month = "March", Lecturer = "Mr. Molele", Hours = 15, Rate = 200, Total = 3000, Status = "Rejected" },
                new { Month = "April", Lecturer = "Mr. Magwaza", Hours = 15, Rate = 200, Total = 3000, Status = "Pending" }

            };

            return View();
        }
    }
}
