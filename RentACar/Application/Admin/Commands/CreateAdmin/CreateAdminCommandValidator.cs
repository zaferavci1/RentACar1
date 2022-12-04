using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Admin.Commands.CreateAdmin
{
    public class CreateAdminCommandValidator:AbstractValidator<CreateAdminCommand>
    {
        public CreateAdminCommandValidator()
        {
            RuleFor(command => command.adminModel.UserName).NotEmpty().MinimumLength(0);
            RuleFor(command => command.adminModel.Password).NotEmpty().MinimumLength(0);
        }
    }
}