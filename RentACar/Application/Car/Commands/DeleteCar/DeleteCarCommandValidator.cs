using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Car.Commands.DeleteCar
{
    public class DeleteCarCommandValidator:AbstractValidator<DeleteCarCommand>
    {
        public DeleteCarCommandValidator()
        {
            RuleFor(command => command.id).GreaterThan(0);
        }
    }
}