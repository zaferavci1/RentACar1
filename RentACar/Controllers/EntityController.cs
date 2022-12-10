using RentACar.Application.Car.Queries.GetCars;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACar.Controllers
{
    public class EntityController : Controller
    {
        RentACarDbContext context = new RentACarDbContext();
        // GET: Entity
        public ActionResult Index()
        {
            GetCarsQuery query = new GetCarsQuery(context);
            var cars = query.Handle();
            return View(cars);
        }
    }
}