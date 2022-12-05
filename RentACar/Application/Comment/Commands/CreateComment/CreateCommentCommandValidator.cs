using FluentValidation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RentACar.Application.Comment.Commands.CreateComment
{
    public class CreateCommentCommandValidator : AbstractValidator<CreateCommentCommand>
    {
        public CreateCommentCommandValidator()
        {
            RuleFor(comment => comment.commentModel.Name).NotEmpty().MinimumLength(0);
            RuleFor(comment => comment.commentModel.PublishDate).NotEmpty().LessThan(x => DateTime.Now).WithMessage("Bugünün tarihinden ileri olmalıdır.");
            RuleFor(comment => comment.commentModel.Description).NotEmpty().Length(5, 100).WithMessage("5 karakterden az 100 karakterden fazla olamaz");
            RuleFor(comment => comment.commentModel.Check).NotNull();
        }
    }
}