using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RentACar.Models.Siniflar;

namespace RentACar.Application.Car.Queries.GetById
{
    public class GetByIdQuery
    {
        private readonly RentACarDbContext _rentACarDbContext;
        
    }
    public class GetCarsQueryModel
    {
        public string Brand { get; set; }
        public Color Color { get; set; }
        public int Price { get; set; }
        public int SeatCount { get; set; }
        public string Description { get; set; }
    }
}
