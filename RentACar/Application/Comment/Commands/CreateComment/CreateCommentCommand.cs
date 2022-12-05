using AutoMapper;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Comment.Commands.CreateComment
{
    public class CreateCommentCommand
    {
        private readonly RentACarDbContext _context;
        private readonly IMapper _mapper;
        public CreateCommentModel commentModel { get; set; }

        public CreateCommentCommand(IMapper mapper, RentACarDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public void Handle()
        {
            var comment = _context.Comments.SingleOrDefault(x => x.Description == commentModel.Description);
            if(comment != null)
            {
                throw new Exception("Bu açıklmada yorum vardır.");
            }
            comment = _mapper.Map<RentACar.Models.Siniflar.Comment>(commentModel);
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }
    }

    public class CreateCommentModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public bool Check { get; set; }
    }
}