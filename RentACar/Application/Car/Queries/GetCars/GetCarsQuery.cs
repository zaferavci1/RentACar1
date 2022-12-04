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
        public GetCarsQuery(RentACarDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<GetCarsModel> Handle()
        { 
            return _mapper.Map <List<GetCarsModel>> (_context.Cars.OrderBy(x=>x.Id).ToList());
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