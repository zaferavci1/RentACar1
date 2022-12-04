using AutoMapper;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Color.Queries.GetById
{
    public class GetByIdColorQuery
    {
        public int id { get; set; }
        private readonly RentACarDbContext _context;
        private readonly IMapper _mapper;

        public GetByIdColorQuery(IMapper mapper, RentACarDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public GetByIdColorModel Handle()
        {
            var color = _context.Colors.SingleOrDefault(x => x.Id == id);
            return _mapper.Map<GetByIdColorModel>(color);
        }
    }

    public class GetByIdColorModel
    {
        public string Name { get; set; }
    }
}