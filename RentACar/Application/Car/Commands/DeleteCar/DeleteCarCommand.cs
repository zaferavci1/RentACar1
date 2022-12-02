using AutoMapper;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Car.Commands.DeleteCar
{
    public class DeleteCarCommand
    {
        public int id { get; set; }
        private readonly IMapper _mapper;
        private readonly RentACarDbContext _context;
        public DeleteCarCommand(IMapper mapper, RentACarDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public void Handle()
        {
            var car = _context.Cars.SingleOrDefault(x => x.Id == id);
            if (car ==null) {
                throw new InvalidOperationException("silinecek araba bulanamdı");
            }
            _context.Cars.Remove(car);
            _context.SaveChanges();
        }
    }
}