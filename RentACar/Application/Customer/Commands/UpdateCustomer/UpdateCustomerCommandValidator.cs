using FluentValidation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RentACar.Application.Customer.Commands.UpdateCustomer
{
    public class UpdateCustomerCommandValidator : AbstractValidator<UpdateCustomerCommand>
    {
        public UpdateCustomerCommandValidator()
        {
            RuleFor(customer => customer.customerModel.Name).NotEmpty().Length(5, 25);
            RuleFor(customer => customer.customerModel.Address).NotEmpty().Length(20, 100);
            RuleFor(customer => customer.customerModel.NationalId).NotEmpty().MinimumLength(11);
            RuleFor(customer => customer.id).NotEmpty().GreaterThan(0);
        }
    }
}