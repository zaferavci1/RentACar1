using AutoMapper;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Color.Commands
{
    public class CreateColorCommand
    {
        private readonly RentACarDbContext _context;
        private readonly IMapper _mapper;
        public CreateColorModel colorModel { get; set; }
        public CreateColorCommand(IMapper mapper, RentACarDbContext context)
        {
            this._mapper = mapper;
            _context = context;
        }

        public void Handle()
        {
            var color = _context.Colors.SingleOrDefault(x => x.Name == colorModel.Name);
            if(color != null)
            {
                throw new Exception("Bu iside renk var");
            }
            color = _mapper.Map<RentACar.Models.Siniflar.Color>(colorModel);
            _context.Colors.Add(color);
            _context.SaveChanges();
        }
    }
    public class CreateColorModel
    {
        public string Name { get; set; }
    }
}