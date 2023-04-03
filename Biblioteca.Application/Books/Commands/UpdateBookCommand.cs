using Biblioteca.Application.Interfaces;
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
    public class UpdateBookCommand : IRequest
    {
        public int IBSN { get; set; }
        public int editoriales_id { get; set; }
        public string titulos { get; set; }
        public string sinopsis { get; set; }
        public int n_paginas { get; set; }
    }

    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand>
    {
        private readonly ILibraryDbContext _context;

        public UpdateBookCommandHandler(ILibraryDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Books.FirstOrDefaultAsync(x => x.IBSN == request.IBSN);

            if(entity == null)
            {
                throw new DllNotFoundException(nameof(Books));
            }

            entity.editoriales_id = request.editoriales_id;
            entity.titulos = request.titulos;
            entity.sinopsis = request.sinopsis;
            entity.n_paginas = request.n_paginas;


            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
