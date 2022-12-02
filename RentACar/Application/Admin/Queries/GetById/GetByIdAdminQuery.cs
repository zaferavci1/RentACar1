using AutoMapper;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Admin.Queries.GetById
{
    public class GetByIdAdminQuery
    {
        private readonly RentACarDbContext _context;
        private readonly IMapper _mapper;
        public int id { get; set; }
        public GetByIdAdminQuery(IMapper mapper, RentACarDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public GetByIdAdminModel Handle()
        {
            var admin = _context.Admins.SingleOrDefault(x => x.Id == id);
            if(admin == null)
            {
                throw new InvalidOperationException("Aranan admin bulunamadı");
            }
            return _mapper.Map<GetByIdAdminModel>(admin);
        }

    }
    public class GetByIdAdminModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}