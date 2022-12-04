using AutoMapper;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Category.Commands.DeleteCategory
{
    public class DeleteCategoryCommand
    {

        private readonly RentACarDbContext _context;
        private readonly IMapper _mapper;
        public int id { get; set; }
        public DeleteCategoryCommand(RentACarDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void Handle()
        {
            var category = _context.Categories.SingleOrDefault(x=>x.Id==id);
            if (category==null)
            {
                throw new InvalidOperationException("Silinecek Kategori Bulunamadı");
            }
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }
    }
}