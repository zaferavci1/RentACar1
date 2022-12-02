using AutoMapper;
using RentACar.Models;
using RentACar.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Car.Queries.GetById
{
    public class GetByIdCarQuery
    {

        private readonly IMapper _mapper;
        private readonly RentACarDbContext _context;
        public int id { get; set; }
        public GetByIdCarQuery(IMapper mapper, RentACarDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public GetByIdCarModel Handle()
        {
            var car = _context.Cars.SingleOrDefault(x=>x.Id==id);
            return _mapper.Map<GetByIdCarModel>(car);
        }

    }
    public class GetByIdCarModel
    { 
            public string Brand { get; set; }
            public Color Color { get; set; }
            public int Price { get; set; }
            public int SeatCount { get; set; }
    }
}