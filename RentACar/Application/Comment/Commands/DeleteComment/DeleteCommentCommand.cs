using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Comment.Commands.DeleteComment
{
    public class DeleteCommentCommand
    {
        public int id { get; set; }
        private readonly RentACarDbContext _context;

        public DeleteCommentCommand(RentACarDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var comment = _context.Comments.FirstOrDefault(x => x.Id == id);
            if(comment == null)
            {
                throw new Exception("Silinecek yorum bulunamadı");
            }
            _context.Comments.Remove(comment);
            _context.SaveChanges();
        }
    }
}