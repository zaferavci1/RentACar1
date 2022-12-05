
using FluentValidation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RentACar.Application.Color.Commands.DeleteColor
{
    public class DeleteColorCommandValidator : AbstractValidator<DeleteColorCommand>
    {
        public DeleteColorCommandValidator()
        {
            RuleFor(color => color.id).GreaterThan(0);
        }
    }
}