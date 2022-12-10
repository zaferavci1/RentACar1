using AutoMapper;
using RentACar.Application.Car.Queries.GetCars;
using RentACar.Common;
using RentACar.Migrations;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACar.Controllers
{
    public class HomeController : Controller
    {
        RentACarDbContext context= new RentACarDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            InitialCreate ınitialCreate = new InitialCreate();
            ınitialCreate.Up();
            GetCarsQuery query = new GetCarsQuery(context);
            
            return View(query.Handle());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}