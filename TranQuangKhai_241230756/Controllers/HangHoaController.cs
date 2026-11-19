using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TranQuangKhai_241230756.Models;

namespace TranQuangKhai_241230756.Controllers
{
    public class HangHoaController : Controller
    {
        private readonly QLHangHoaContext _db;
        public HangHoaController(QLHangHoaContext db) => _db = db;
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.MaLoai = new SelectList(_db.LoaiHangs, "MaLoai", "TenLoai");
            return View();
        }
        [HttpPost]
        public IActionResult Create(HangHoa h)
        {
            if (ModelState.IsValid)
            {
                _db.HangHoas.Add(h);
                _db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            ViewBag.MaLoai = new SelectList(_db.LoaiHangs, "MaLoai", "TenLoai", h.MaLoai);
            return View(h);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
