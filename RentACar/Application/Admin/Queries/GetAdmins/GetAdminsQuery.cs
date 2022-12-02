using AutoMapper;
using RentACar.Models;
using RentACar.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Admin.Queries.GetAdmins
{
    public class GetAdminsQuery
    {
        private readonly RentACarDbContext _context;
        private readonly IMapper _mapper;
        public GetAdminsQuery(IMapper mapper, RentACarDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public List<GetAdminsModel> Handle()
        {
            return _mapper.Map<List<GetAdminsModel>>(_context.Admins.OrderBy(x=>x.Id).ToList<RentACar.Models.Siniflar.Admin>());
        }

    }
    public class GetAdminsModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}