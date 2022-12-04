using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Admin.Commands.DeleteAdmin
{
    public class DeleteAdminCommandValidator:AbstractValidator<DeleteAdminCommand>
    {
        public DeleteAdminCommandValidator()
        {
            RuleFor(command=>command.id).GreaterThan(0);
        }
    }
}