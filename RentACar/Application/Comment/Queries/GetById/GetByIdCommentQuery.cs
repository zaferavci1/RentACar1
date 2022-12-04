using AutoMapper;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Comment.Queries.GetById
{
    public class GetByIdCommentQuery
    {
        public int id { get; set; }
        private readonly RentACarDbContext _context;
        private readonly IMapper _mapper;

        public GetByIdCommentQuery(IMapper mapper, RentACarDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public GetByIdCommentModel Handle()
        {
            var comment = _context.Comments.FirstOrDefault(x => x.Id == id);
            return _mapper.Map<GetByIdCommentModel>(comment);
        }
    }

    public class GetByIdCommentModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public bool Check { get; set; } = false;
    }
}