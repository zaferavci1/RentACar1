using FluentValidation;
using RentACar.Application.Car.Commands.CreateCar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Admin.Commands.CreateAdmin
{
    public class CreateCarCommandValidator:AbstractValidator<CreateCarCommand>
    {
        public CreateCarCommandValidator()
        {
            RuleFor(command => command.carModel.Color.Name).NotEmpty().MinimumLength(0);
            RuleFor(command => command.carModel.Brand).NotEmpty().MinimumLength(0);
            RuleFor(command => command.carModel.Price).GreaterThan(0);
            RuleFor(command => command.carModel.SeatCount).GreaterThan(0);

        }
    }
}