using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Admin.Commands.UpdateAdmin
{
    public class UpdateAdminCommandValidator:AbstractValidator<UpdateAdminCommand>
    {
        public UpdateAdminCommandValidator()
        {
            RuleFor(command=>command.model.UserName).NotEmpty().MinimumLength(0);
            RuleFor(command=>command.model.Password).NotEmpty().MinimumLength(0);
            RuleFor(command => command.id).GreaterThan(0);
        }
    }
}