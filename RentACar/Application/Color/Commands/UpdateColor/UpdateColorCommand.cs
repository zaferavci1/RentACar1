using AutoMapper;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Color.Commands.UpdateColor
{
    public class UpdateColorCommand
    {
        private readonly RentACarDbContext _context;
        private readonly IMapper mapper;
        public UpdateColorModel colorModel{ get; set; }
        public int id { get; set; }
        public UpdateColorCommand(IMapper mapper, RentACarDbContext context)
        {
            this.mapper = mapper;
            _context = context;
        }

        public void Handle()
        {
            var color = _context.Colors.SingleOrDefault(x => x.Id == id);
            if(color == null)
            {
                throw new Exception("renk bulunamadi");
            }
            color.Name = colorModel.Name == default ? color.Name : colorModel.Name;
            _context.SaveChanges();
        }
    }
    public class UpdateColorModel
    {
        public string Name { get; set; }
    }
}