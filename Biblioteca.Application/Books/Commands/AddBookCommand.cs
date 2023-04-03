using Biblioteca.Application.Interfaces;
using Biblioteca.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca.Application.Books.Commands
{
    public class AddBookCommand : IRequest<bool>
    {
        public int editoriales_id { get; set; }
        public string titulos { get; set; }
        public string sinopsis { get; set; }
        public int n_paginas { get; set; }
    }

    public class AddBookCommandHandler : IRequestHandler<AddBookCommand, bool>
    {
        private readonly ILibraryDbContext _context;

        public AddBookCommandHandler(ILibraryDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(AddBookCommand request, CancellationToken cancellationToken)
        {
            bool accion = false;

            try
            {
                Book entity = new Book
                {
                    editoriales_id = request.editoriales_id,
                    titulos = request.titulos,
                    sinopsis = request.sinopsis,
                    n_paginas = request.n_paginas
                };

                _context.Books.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                accion = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return accion;
        }
    }
}
