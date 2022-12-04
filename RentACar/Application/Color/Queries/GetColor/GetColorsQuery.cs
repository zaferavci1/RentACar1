using AutoMapper;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Color.Queries.GetColor
{
    public class GetColorsQuery
    {
        private readonly RentACarDbContext _context;
        private readonly IMapper _mapper;

        public GetColorsQuery(IMapper mapper, RentACarDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public List<GetColorsModel> Handle()
        {
            return _mapper.Map<List<GetColorsModel>>(_context.Colors.OrderBy(x => x.Id).ToList());
        }
    }

    public class GetColorsModel
    {
        public string Name { get; set; }
    }
}