
using FluentValidation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RentACar.Application.Color.Commands.UpdateColor
{
    public class UpdateColorCommandValidator : AbstractValidator<UpdateColorCommand>
    {
        public UpdateColorCommandValidator()
        {
            RuleFor(color => color.colorModel.Name).NotEmpty().MinimumLength(0);
        }
    }
}