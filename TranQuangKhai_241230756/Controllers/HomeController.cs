using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TranQuangKhai_241230756.Models;

namespace TranQuangKhai_241230756.Controllers
{
    public class HomeController : Controller
    {
        private readonly QLHangHoaContext _db;
        public HomeController(QLHangHoaContext db) => _db = db;
        public IActionResult Index()
        {
            var ds = _db.HangHoas.Where(h => h.Gia >= 100).ToList();
            return View(ds);
        }
        public IActionResult LocTheoLoai(int maLoai)
        {
            var ds = _db.HangHoas.Where(h => h.MaLoai == maLoai).ToList();
            return PartialView("TranQuangKhai_MainContent", ds);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
