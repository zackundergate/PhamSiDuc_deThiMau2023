using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PhamSiDuc_deThiMau2023.Models;

namespace PhamSiDuc_deThiMau2023.Controllers
{
    public class HangHoaController : Controller
    {
        private readonly QlhangHoaContext _context;

        public HangHoaController(QlhangHoaContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            ViewBag.MaLoai = new SelectList(_context.LoaiHangs, "MaLoai", "TenLoai");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HangHoa hangHoa)
        {
            if (ModelState.IsValid)
            {
                _context.HangHoas.Add(hangHoa);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            ViewBag.MaLoai = new SelectList(_context.LoaiHangs, "MaLoai", "TenLoai", hangHoa.MaLoai);
            return View(hangHoa);
        }
    }
}
