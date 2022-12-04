using AutoMapper;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Comment.Commands.UpdateComment
{
    public class UpdateCommentCommand
    {
        private readonly RentACarDbContext _context;
        private readonly IMapper _mapper;
        public UpdateCommentModel commentModel { get; set; }
        public UpdateCommentCommand(RentACarDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public int id { get; set; }

        public void Handle()
        {
            var comment = _context.Comments.FirstOrDefault(x => x.Id == id);
            if(comment == null)
            {
                throw new Exception("Güncellenecek yorum bulunamadı");
            }
            comment.Name = commentModel.Name = default ? comment.Name : commentModel.Name;
            comment.Description = commentModel.Description = default ? comment.Description : commentModel.Description;
            comment.PublishDate = commentModel.PublishDate = default ? comment.PublishDate : commentModel.PublishDate;
            comment.Check = commentModel.Check = default ? comment.Check : commentModel.Check;
            _context.SaveChanges();
        }
    }

    public class UpdateCommentModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public bool Check { get; set; } = false;
    }
}