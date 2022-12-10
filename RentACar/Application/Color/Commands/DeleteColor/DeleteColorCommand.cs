using AutoMapper;
using Microsoft.Ajax.Utilities;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Color.Commands
{
    public class DeleteColorCommand
    {
        private readonly RentACarDbContext _context;
        public int id { get; set; }

        public DeleteColorCommand(RentACarDbContext context)
        {
            _context = context;
        }
        
        public void Handle()
        {
            var color = _context.Colors.SingleOrDefault(x => x.Id == id);
            if(color == null)
            {
                throw new Exception("silinecek renk yok");
            }
            var cars = _context.Cars.FirstOrDefault(x => x.ColorId == color.Id);
            if(cars==null)
            {
                throw new Exception("silinecek rengin kullanıldıgı arabalar var. Renk silinemez.");
            }
            _context.Colors.Remove(color);
            _context.SaveChanges();
        }

    }
}