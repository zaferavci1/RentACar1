using AutoMapper;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Category.Commands.CreateCategory
{
    public class CreateCategoryCommand
    {
        private readonly RentACarDbContext _context;
        private readonly IMapper _mapper;
        public CreateCategoryModel model { get; set; }
        public CreateCategoryCommand(RentACarDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void Handle()
        {
            var category = _context.Categories.SingleOrDefault(x => x.CategoryName == model.CategoryName);
            if(category != null)
            {
                throw new InvalidOperationException("Olusturulmak istenen kategori zaten mevcut");
            }
            RentACar.Models.Siniflar.Category category1 = _mapper.Map<RentACar.Models.Siniflar.Category>(category);
            _context.Categories.Add(category1);
            _context.SaveChanges();
        }
    }
    public class CreateCategoryModel
    {
        public string CategoryName { get; set; }
    }
}