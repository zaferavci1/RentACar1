using AutoMapper;
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
            if(color != null)
            {
                throw new Exception("silinecek renk yok");
            }
            _context.Colors.Remove(color);
            _context.SaveChanges();
        }

    }
}