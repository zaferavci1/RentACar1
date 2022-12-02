using AutoMapper;
using RentACar.Models;
using RentACar.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Car.Commands
{
    public class CreateCarCommand
    {
        private readonly IMapper mapper;
        public CreateCarModel carModel { get; set; }
        private readonly Context _context;
        public CreateCarCommand(IMapper mapper , Context context  )
        {
            this.mapper = mapper;
            this._context = context;
        }

        public void Handle()
        {
            var car = _context.Cars.SingleOrDefault(x => x.Brand == carModel.Brand);
            if(car != null)
            {
                throw new Exception("bu markada bir araba var");
            }

            _context.Cars.Add(car);
            _context.SaveChanges();
            //serkan
        }
    }

    public class CreateCarModel
    {
        public string Brand { get; set; }
        public Color Color { get; set; }
        public int Price { get; set; }
        public int SeatCount { get; set; }
    }
}