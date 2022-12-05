using AutoMapper;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Application.Comment.Queries.GetComment
{
    public class GetCommentsQuery
    {
        private readonly RentACarDbContext _context;
        private readonly IMapper _mapper;

        public GetCommentsQuery(IMapper mapper, RentACarDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public List<GetCommentsModel> Handle()
        {
            return _mapper.Map<List<GetCommentsModel>>(_context.Comments.OrderBy(x => x.Id).ToList());
        }
        
    }
    public class GetCommentsModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public bool Check { get; set; } = false;
    }
}