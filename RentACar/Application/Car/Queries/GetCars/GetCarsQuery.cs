using AutoMapper;
using RentACar.Models;
using RentACar.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Car.Queries.GetCars
{
    public class GetCarsQuery
    {
        private readonly IMapper _mapper;
        private readonly RentACarDbContext _context;
        public GetCarsQuery(RentACarDbContext context)
        {
            _context = context;
        }
        public List<GetCarsModel> Handle()
        {
            var cars = new List<GetCarsModel>();
            var car = new GetCarsModel();
            foreach (var item in _context.Cars.OrderBy(x=>x.Id))
            {
                car.Brand = item.Brand;
                car.Color=item.Color;
                car.Price=item.Price;
                car.SeatCount = item.SeatCount;
                cars.Add(car);
            }
            return cars;
        }
    }
    public class GetCarsModel
    { 
        public string Brand { get; set; }
        public RentACar.Models.Siniflar.Color Color { get; set; }
        public int Price { get; set; }
        public int SeatCount { get; set; }
    }
}