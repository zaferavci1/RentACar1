using AutoMapper;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Customer.Commands.UpdateCustomer
{
    public class UpdateCustomerCommand
    {
        public UpdateCustomerModel customerModel;
        private readonly RentACarDbContext _context;
        private readonly IMapper _mapper;
        public int id { get; set; }

        public UpdateCustomerCommand(IMapper mapper, RentACarDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public void Handle()
        {
            var customer = _context.Customers.FirstOrDefault(x => x.Id == id);
            if(customer == null)
            {
                throw new Exception("Müşteri bulunamadı");
            }
            customer.Name = customerModel.Name = default ? customer.Name : customerModel.Name;
            customer.Tc = customerModel.Tc = default ? customer.Tc : customerModel.Tc;
            customer.Address = customerModel.Address = default ? customer.Address : customerModel.Address;
            _context.SaveChanges();
        }
    }
    public class UpdateCustomerModel
    {
        public string Tc { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}