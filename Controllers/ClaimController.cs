using Microsoft.AspNetCore.Mvc;

namespace POE_MVC_Part_1.Controllers
{
    public class ClaimsController : Controller
    {
        // GET: /Claims/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Claims/Create
        [HttpPost]
        public IActionResult Create(string month, int hours, decimal rate, string documentName)
        {
            //Calculation
            decimal total = hours * rate;

            // Store in temporary data to show on MyClaims
            ViewBag.month = month;
            ViewBag.hours = hours;
            ViewBag.rate = rate;
            ViewBag.total = total;
            ViewBag.document = documentName;
            ViewBag.status = "Pending";

            return RedirectToAction("MyClaims");
        }

        // GET: /Claims/MyClaims
        public IActionResult MyClaims()
        {
            return View();
        }

        // GET: /Claims/Details
        public IActionResult Details(string month, int hours, decimal rate, decimal total, string document, string status)
        {
            // Pass values to ViewBag 
            ViewBag.month = month;
            ViewBag.hours = hours;
            ViewBag.rate = rate;
            ViewBag.total = total;
            ViewBag.document = document;
            ViewBag.status = status;

            return View();
        }
    }
}
