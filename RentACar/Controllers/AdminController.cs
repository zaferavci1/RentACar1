using RentACar.Application.Car.Queries;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACar.Controllers
{
    public class AdminController : Controller
    {
        Context context;
        // GET: Admin
        public ActionResult Index()
        {
            GetCarsQuery query = new GetCarsQuery(context);
            return View(query.Handle());
        }
    }
}