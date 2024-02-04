using Microsoft.AspNetCore.Mvc;
using CustomIdentity.ViewModels;
using CustomIdentity.Models;
using System.Linq;
using CustomIdentity.Data;

namespace CustomIdentity.Controllers
{
    public class SozlukController : Controller
    {
        private readonly AppDbContext _context;

        public SozlukController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var eklenmisSozcukler = _context.Sozlugunuz.ToList();

            if (eklenmisSozcukler.Any())
            {
                var sozlukVerileri = eklenmisSozcukler.Select(sozcuk => new SozlukVM
                {
                    Kelime = sozcuk.Kelime,
                    Cumle = sozcuk.Cumle,
                    Tarih = sozcuk.Tarih
                }).ToList();

                return Json(sozlukVerileri);
            }
            else
            {
                return Json(new List<SozlukVM>());
            }
        }


        public IActionResult Ekle()
        {
            var eklenmisSozcukler = _context.Sozlugunuz.ToList();
            var viewModel = new SozlukVM
            {
                EklenmisSozcukler = eklenmisSozcukler
            };

            
            ViewBag.EklenmisSozcukler = eklenmisSozcukler;

            return View("Index", viewModel);
        }
        [HttpPost]
        public IActionResult Ekle(SozlukVM model)
        {
            if (ModelState.IsValid)
            {
                var sozluk = new Sozluk
                {
                    Kelime = model.Kelime,
                    Cumle = model.Cumle,
                    Tarih = model.Tarih
                };

                _context.Sozlugunuz.Add(sozluk);
                _context.SaveChanges();

           
                var eklenmisSozcukler = _context.Sozlugunuz.ToList();
                var viewModel = new SozlukVM
                {
                    EklenmisSozcukler = eklenmisSozcukler
                };

           
                ViewBag.EklenmisSozcukler = eklenmisSozcukler;

                return View("Index", viewModel);
            }

      
            return View(model);
        }



    }
}
