using gropgit.DAL;
using gropgit.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gropgit.Controllers
{
    public class ShooseController1 : Controller
    {
        // GET: ShooseController1
        //הצגת הנעליים
        public ActionResult Index()
        {
            return View(Data.Get.Shoes);
        }

        // GET: ShooseController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ShooseController1/Create
        //יצירת טבלת הוספה
        public ActionResult Create()
        {
            return View();
        }
        //הוספת נעל
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Shoe shoe)
        {
            if (shoe == null) return RedirectToAction("Create");
            Data.Get.Shoes.Add(shoe);
            Data.Get.SaveChanges();
            return RedirectToAction("Index");
            
        }
        //מחיקת נעל
        public ActionResult Delete(int id)
        {
            if (id == null) return RedirectToAction("Index");
            var liberyy = Data.Get.Shoes.FirstOrDefault(f => f.ShoeId == id);
            Data.Get.Shoes.Remove(liberyy);
            Data.Get.SaveChanges();
            return RedirectToAction("Index");
           
        }


        // POST: ShooseController1/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: ShooseController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShooseController1/Edit/5
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

        // GET: ShooseController1/Delete/5
       
        // POST: ShooseController1/Delete/5
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
