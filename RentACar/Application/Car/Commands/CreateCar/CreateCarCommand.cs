using AutoMapper;
using RentACar.Models;
using RentACar.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Car.Commands.CreateCar
{
    public class CreateCarCommand
    {
        private readonly IMapper _mapper;
        private readonly RentACarDbContext _context;
        public CreateCarModel carModel { get; set; }
        public CreateCarCommand(IMapper mapper , RentACarDbContext context  )
        {
            _mapper = mapper;
            _context = context;
        }

        public void Handle()
        {
            var car = _context.Cars.SingleOrDefault(x => x.Brand == carModel.Brand);
            if(car != null)
            {
                throw new Exception("bu markada bir araba var");
            }
            car = _mapper.Map<RentACar.Models.Siniflar.Car>(carModel);
            _context.Cars.Add(car);
            _context.SaveChanges();
        }
    }

    public class CreateCarModel
    {
        public string Brand { get; set; }
        public RentACar.Models.Siniflar.Color Color { get; set; }
        public int Price { get; set; }
        public int SeatCount { get; set; }
    }
}