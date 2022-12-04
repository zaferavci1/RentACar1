using AutoMapper;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Admin.Commands.UpdateAdmin
{
    public class UpdateCategoryCommand
    {
        public int id { get; set; }
        private readonly IMapper _mapper;
        private readonly RentACarDbContext _context;
        public UpdateAdminModel model { get; set; }
        public UpdateCategoryCommand(RentACarDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void Handle()
        {
            var admin = _context.Admins.SingleOrDefault(x => x.Id == id);
            if(admin == null)
            {
                throw new InvalidOperationException("Güncellenecek admin bulunamadı");
            }
            admin.UserName = model.UserName == default ? admin.UserName : model.UserName;
            admin.Password = model.Password == default ? admin.Password : model.Password;

        }
    }
    public class UpdateAdminModel
    { 
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}