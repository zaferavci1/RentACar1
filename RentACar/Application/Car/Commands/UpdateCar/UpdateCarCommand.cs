using AutoMapper;
using RentACar.Models;
using RentACar.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Car.Commands.DeleteCar
{
    public class UpdateCarCommand
    {
        private readonly RentACarDbContext _context;
        private readonly IMapper _mapper;
        public UpdateCarModel model { get; set; }
        public int id { get; set; }
        public UpdateCarCommand(IMapper mapper, RentACarDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public void Handle()
        {
            var car = _context.Cars.SingleOrDefault(x => x.Id == id);
            if(car ==null)
            {
                throw new InvalidOperationException("Araba bulunamadi");
            }
            car.Color = model.Color == default ? car.Color : model.Color;
            car.Brand = model.Brand == default ? car.Brand : model.Brand;
            car.Price = model.Price == default ? car.Price : model.Price;
            car.SeatCount = model.SeatCount == default ? car.SeatCount : model.SeatCount;
            _context.SaveChanges();


        }
    }
    public class UpdateCarModel
    { 
        public string Brand { get; set; }
        public Color Color { get; set; }
        public int Price { get; set; }
        public int SeatCount { get; set; }

    }
}