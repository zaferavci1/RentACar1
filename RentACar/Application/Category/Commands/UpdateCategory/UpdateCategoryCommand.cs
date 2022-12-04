using AutoMapper;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Category.Commands.UpdateCategory
{
    public class UpdateCategoryCommand
    {

        private readonly RentACarDbContext _context;
        private readonly IMapper _mapper;
        public UpdateCategoryModel model { get; set; }
        public int id { get; set; }
        public UpdateCategoryCommand(RentACarDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void Handle()
        {
            var category = _context.Categories.FirstOrDefault(x=>x.Id==id);
            if(category==null)
            {
                throw new InvalidOperationException("Guncellenecek kategori bulunamadı");
            }
            category.CategoryName=model.CategoryName==default?category.CategoryName:model.CategoryName;
            _context.SaveChanges();
        }
    }
    public class UpdateCategoryModel
    {
        public string CategoryName { get; set; }
    }
}