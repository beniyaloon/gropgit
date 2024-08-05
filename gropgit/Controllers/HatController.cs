using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gropgit.Controllers
{
    public class HatController : Controller
    {
        // GET: HatController
        public ActionResult Index()
        {
            return View();
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
        public ActionResult Create(IFormCollection collection)
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
