using eticaretMVC.Data;
using eticaretMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace eticaretMVC.Controllers
{
    public class UrunIslemleri : Controller
    {
        private readonly FakeData _context;

        public UrunIslemleri(FakeData context) // context ---> new FakeData()
        {
            _context = context;
        }



        public IActionResult Index()
        {

            return View(_context.Urunler);
        }


        public IActionResult Details(int id)
        {
            // id(int) ---- LINQ ----> Urun(referans)
            var urun = _context.Urunler.Where(x => x.Barkod == id).SingleOrDefault();

            return View(urun); // vies/UrunIslemleri/Details.cshtml
        }
        public IActionResult Delete(int id)
        {

            var urun = _context.Urunler.Where(x => x.Barkod == id).SingleOrDefault();
            
            return View(urun);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {

            var urun = _context.Urunler.Where(x => x.Barkod == id).SingleOrDefault();
            _context.Urunler.Remove(urun);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]   // Submit edildiğinde çalışır
        public IActionResult Create(Urun urun)
        {
            _context.Urunler.Add(urun);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var urun = _context.Urunler.Where(x => x.Barkod == id).SingleOrDefault();

            return View(urun);
        }

        [HttpPost]   // Submit edildiğinde çalışır
        public async Task<IActionResult> Edit(Urun urun)
        {
            var güncellenecekUrun = _context.Urunler.SingleOrDefault(x => x.Barkod == urun.Barkod);

            await TryUpdateModelAsync(güncellenecekUrun);

            return RedirectToAction("Index");
        }





    }
}
