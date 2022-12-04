using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Car.Queries.GetById
{
    public class GetByIdCarQueryValidator:AbstractValidator<GetByIdCarQuery>
    {
        public GetByIdCarQueryValidator()
        {
            RuleFor(query => query.id).GreaterThan(0);
        }
    }
}