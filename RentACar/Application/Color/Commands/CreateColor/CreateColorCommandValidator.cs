using FluentValidation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RentACar.Application.Color.Commands.CreateColor
{
    public class CreateColorCommandValidator : AbstractValidator<CreateColorCommand>
    {
        public CreateColorCommandValidator()
        {
            RuleFor(command => command.colorModel.Name).NotEmpty().MinimumLength(0);
        }
    }
}