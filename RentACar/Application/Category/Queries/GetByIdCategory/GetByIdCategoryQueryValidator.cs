using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Category.Queries.GetByIdCategory
{
    public class GetByIdCategoryQueryValidator:AbstractValidator<GetByIdCategoryQuery>
    {
        public GetByIdCategoryQueryValidator()
        {
            RuleFor(query => query.id).GreaterThan(0);
        }
    }
}