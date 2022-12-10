using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq; 
using System.Web;
using RentACar.Models.Siniflar;

namespace RentACar.Application.Car.Queries
{
    public class GetCarsQuery
    {
        private readonly Context _context;
        public GetCarsQuery(Context context)
        {
            _context = context;
        }
        public List<RentACar.Models.Siniflar.Car> Handle()
        {
            return _context.Cars.OrderBy(x => x.Id).ToList();
        }
    }
}