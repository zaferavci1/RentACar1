using AutoMapper;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Customer.Queries.GetCustomer
{
    public class GetCustomersQuery
    {
        private readonly RentACarDbContext _context;
        private readonly IMapper _mapper;

        public GetCustomersQuery(IMapper mapper, RentACarDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public List<GetCustomersModel> Handle()
        {
            return _mapper.Map<List<GetCustomersModel>>(_context.Comments.OrderBy(x => x.Id).ToList());
        }
    }

    public class GetCustomersModel
    {
        public string Name { get; set; }
        public string NationalId { get; set; }
        public string Address { get; set; }
    }
}