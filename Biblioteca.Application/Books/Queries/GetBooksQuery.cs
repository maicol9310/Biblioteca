using AutoMapper;
using AutoMapper.QueryableExtensions;
using Biblioteca.Application.Interfaces;
using Biblioteca.Application.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca.Application.Books.Queries
{
    public class GetBooksQuery: IRequest<List<BookDto>>
    {
    }

    public class GetBooksQueryHandler : IRequestHandler<GetBooksQuery, List<BookDto>>
    {
        private readonly ILibraryDbContext _context;
        private readonly IMapper _mapper;

        public GetBooksQueryHandler(ILibraryDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<BookDto>> Handle(GetBooksQuery request, CancellationToken cancellationToken)
        {
            List<BookDto> content = new List<BookDto>();

            content = await _context.Books
                    .ProjectTo<BookDto>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);

            return content;
        }
    }
}
