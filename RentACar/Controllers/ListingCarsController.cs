using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACar.Controllers
{
    public class ListingCarsController : Controller
    {
        // GET: ListingCars
        public ActionResult Index()
        {
            return View();
        }

        // GET: ListingCars/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ListingCars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ListingCars/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ListingCars/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ListingCars/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ListingCars/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ListingCars/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
