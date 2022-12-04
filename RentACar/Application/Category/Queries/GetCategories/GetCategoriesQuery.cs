using AutoMapper;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Category.Queries.GetCategories
{
    public class GetCategoriesQuery
    {
        private readonly RentACarDbContext _context;
        private readonly IMapper _mapper;
        public GetCategoriesQuery(IMapper mapper, RentACarDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public List<GetCategoriesModel> Handle()
        {
            return _mapper.Map<List<GetCategoriesModel>>(_context.Categories.OrderBy(x=>x.Id).ToList());
        }
    }
    public class GetCategoriesModel
    {
        public string CategoryName { get; set; }
    }
}