using Microsoft.AspNetCore.Mvc;
using PhamSiDuc_deThiMau2023.Models;

namespace PhamSiDuc_deThiMau2023.Controllers
{
    public class HomeController : Controller
    {
        private readonly QlhangHoaContext _context;

        public HomeController(QlhangHoaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.HangHoas.Where(x => x.Gia >= 100).ToList();
            return View(data);
        }

        public IActionResult LocHang(int id)
        {
            var data = (id == 0)
                ? _context.HangHoas.Where(x => x.Gia >= 100).ToList()
                : _context.HangHoas.Where(x => x.MaLoai == id).ToList();

            return PartialView("_DanhSach", data);
        }
    }
}
