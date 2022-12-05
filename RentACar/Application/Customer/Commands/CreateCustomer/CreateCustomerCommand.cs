using AutoMapper;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Customer.Commands.CreateCustomer
{
    public class CreateCustomerCommand
    {
        private readonly IMapper _mapper;
        private readonly RentACarDbContext _context;
        public CreateCustomerModel customerModel { get; set; }

        public CreateCustomerCommand(RentACarDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Handle()
        {
            var customer = _context.Customers.FirstOrDefault(x => x.NationalId == customerModel.NationalId);
            if(customer != null)
            {
                throw new Exception("Aynı Tc'ye sahip kişi bulunuyor.");
            }
            customer = _mapper.Map<RentACar.Models.Siniflar.Customer>(customerModel);
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }
    }

    public  class CreateCustomerModel
    {
        public string Name { get; set; }
        public string NationalId { get; set; }
        public string Address { get; set; }
    }
}