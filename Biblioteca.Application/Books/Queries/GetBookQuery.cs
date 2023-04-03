using AutoMapper;
using AutoMapper.QueryableExtensions;
using Biblioteca.Application.Interfaces;
using Biblioteca.Application.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca.Application.Books.Queries
{
    public class GetBookQuery: IRequest<BookDto>
    {
        public int? IBSN { get; set; }
    }

    public class GetBookQueryHandler : IRequestHandler<GetBookQuery, BookDto>
    {
        private readonly ILibraryDbContext _context;
        private readonly IMapper _mapper;

        public GetBookQueryHandler(ILibraryDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<BookDto> Handle(GetBookQuery request, CancellationToken cancellationToken)
        {
            BookDto content = new BookDto();

            content = await _context.Books
                    .ProjectTo<BookDto>(_mapper.ConfigurationProvider)
                    .FirstOrDefaultAsync(x => x.IBSN == request.IBSN, cancellationToken);

            return content;
        }
    }
}
