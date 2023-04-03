using AutoMapper;
using AutoMapper.QueryableExtensions;
using Biblioteca.Application.Interfaces;
using Biblioteca.Application.Models;
using Biblioteca.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca.Application.Books.Commands
{
    public class DeleteBookCommand : IRequest
    {
        public int? IBSN { get; set; }
    }

    public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand>
    {
        private readonly ILibraryDbContext _context;
        private readonly IMapper _mapper;

        public DeleteBookCommandHandler(
            ILibraryDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            Book result = new Book();

            result = await _context.Books
                    .FirstOrDefaultAsync(x => x.IBSN == request.IBSN, cancellationToken);

            if (result == null)
            {
                throw new DllNotFoundException(nameof(Books));
            }

            _context.Books.Remove(result);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
