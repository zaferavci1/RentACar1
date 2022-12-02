using AutoMapper;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Admin.Commands.DeleteAdmin
{
    public class DeleteAdminCommand
    {

        private readonly RentACarDbContext _context;
        public int id { get; set; }
        public DeleteAdminCommand(RentACarDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var admin = _context.Admins.SingleOrDefault(x => x.Id == id);
            if(admin == null)
            {
                throw new InvalidOperationException("Silinecek admin bulunamadı");
            }
            _context.Admins.Remove(admin);
            _context.SaveChanges();
        }
    }
}