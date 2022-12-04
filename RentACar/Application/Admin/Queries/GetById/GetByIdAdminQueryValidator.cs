using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Admin.Queries.GetById
{
    public class GetByIdAdminQueryValidator:AbstractValidator<GetByIdAdminQuery>
    {
        public GetByIdAdminQueryValidator()
        {
            RuleFor(query => query.id).GreaterThan(0);
        }
    }
}