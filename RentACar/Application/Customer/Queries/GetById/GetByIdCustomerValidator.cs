using FluentValidation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RentACar.Application.Customer.Queries.GetById
{
    public class GetByIdCustomerValidator : AbstractValidator<GetByIdCustomerQuery>
    {
        public GetByIdCustomerValidator()
        {
            RuleFor(customer => customer.id).NotEmpty().GreaterThan(0);
        }
    }
}