using AutoMapper;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Category.Queries.GetByIdCategory
{
    public class GetByIdCategoryQuery
    {
        private readonly RentACarDbContext _context;
        private readonly IMapper _mapper;
        public int id { get; set; }
        public GetByIdCategoryModel model { get; set; }
        public GetByIdCategoryQuery(RentACarDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public GetByIdCategoryModel Handle()
        {
            var category = _context.Categories.SingleOrDefault(x=>x.Id==id);
            if(category==null)
            {
                throw new InvalidOperationException("Aranan kategori bulunamadı");
            }
            return _mapper.Map<GetByIdCategoryModel>(category);
        }

    }
    public class GetByIdCategoryModel
    {
        public string CategoryName { get; set; }
    }
}