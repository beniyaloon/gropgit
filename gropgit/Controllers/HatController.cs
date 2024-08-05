using gropgit.DAL;
using gropgit.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gropgit.Controllers
{
    public class HatController : Controller
    {
        // GET: HatController
        public ActionResult IndexHat()
        {
            return View(Data.Get.Hats);
        }

        // GET: HatController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HatController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HatController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Hat hat)
        {
            if (hat == null) return RedirectToAction("Create");
            Data.Get.Hats.Add(hat);
            Data.Get.SaveChanges();
            return RedirectToAction("IndexHat");
        
        }

        // GET: HatController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HatController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HatController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HatController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
