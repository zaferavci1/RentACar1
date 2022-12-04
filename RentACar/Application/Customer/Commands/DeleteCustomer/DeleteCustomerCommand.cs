using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Customer.Commands.DeleteCustomer
{
    public class DeleteCustomerCommand
    {
        private readonly RentACarDbContext _context;

        public DeleteCustomerCommand(RentACarDbContext context)
        {
            _context = context;
        }
        public int id { get; set; }

        public void Handle()
        {
            var customer = _context.Customers.FirstOrDefault(x => x.Id == id);
            if(customer == null)
            {
                throw new Exception("Silinecek müşteri bulunamadı");
            }
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }
    }
}