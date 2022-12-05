using AutoMapper;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Customer.Queries.GetById
{
    public class GetByIdCustomerQuery
    {
        private readonly RentACarDbContext _context;
        private readonly IMapper _mapper;
        public int id { get; set; }
        public GetByIdCustomerQuery(IMapper mapper, RentACarDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        
        public GetByIdCustomerModel Handle()
        {
            var customer = _context.Customers.SingleOrDefault(x => x.Id == id);
            return _mapper.Map<GetByIdCustomerModel>(_context.Customers);
        }
    }

    public class GetByIdCustomerModel
    {
        public string Name { get; set; }
        public string NationalId { get; set; }
        public string Address { get; set; }
    }
}
