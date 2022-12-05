using FluentValidation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RentACar.Application.Color.Queries.GetById
{
    public class GetByIdColorQueryValidator:AbstractValidator<GetByIdColorQuery>
    {
        public GetByIdColorQueryValidator()
        {
            RuleFor(color => color.id).NotEmpty().GreaterThan(0);
        }
    }
}