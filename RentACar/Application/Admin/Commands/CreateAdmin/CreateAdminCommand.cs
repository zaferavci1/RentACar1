using AutoMapper;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Admin.Commands.CreateAdmin
{
    public class CreateAdminCommand
    {
        public CreateAdminModel adminModel { get; set; }
        private readonly RentACarDbContext _context;
        private readonly IMapper _mapper;

        public CreateAdminCommand(RentACarDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void Handle()
        {
            var admin = _context.Admins.FirstOrDefault(x=>x.UserName==adminModel.UserName);
            if(admin !=null)
            {
                throw new InvalidOperationException("Admin zaten bulunuyor");
            }
            _context.Admins.Add(_mapper.Map<RentACar.Models.Siniflar.Admin>(adminModel));
            _context.SaveChanges();
        }
    }
    public class CreateAdminModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}