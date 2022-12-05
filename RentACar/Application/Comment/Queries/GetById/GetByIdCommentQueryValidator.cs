using FluentValidation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RentACar.Application.Comment.Queries.GetById
{
    public class GetByIdCommentQueryValidator : AbstractValidator<GetByIdCommentQuery>
    {
        public GetByIdCommentQueryValidator()
        {
            RuleFor(comment => comment.id).NotEmpty().GreaterThan(0);
        }
    }
}