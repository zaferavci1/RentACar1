using FluentValidation;
using RentACar.Application.Car.Commands.DeleteCar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Car.Commands.UpdateCar
{
    public class UpdateCarCommandValidator:AbstractValidator<UpdateCarCommand>
    {
        public UpdateCarCommandValidator()
        {
            RuleFor(command => command.model.Brand).NotEmpty().MinimumLength(0);
            RuleFor(command => command.model.Color.Name).NotEmpty().MinimumLength(0);
            RuleFor(command => command.model.Price).GreaterThan(0);
            RuleFor(command => command.model.SeatCount).GreaterThan(0);
            RuleFor(command => command.id).GreaterThan(0);
        }
    }
}