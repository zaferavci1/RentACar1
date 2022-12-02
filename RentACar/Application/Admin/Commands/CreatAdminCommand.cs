using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Admin.Commands
{
    public class CreatAdminCommand
    {
        public CreateAdminModel adminModel { get; set; }
        private readonly Context _context;

        public CreatAdminCommand(Context context)
        { 
            _context = context;
        }
        public void Handle()
        {
            
        }
    }
    public class CreateAdminModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}