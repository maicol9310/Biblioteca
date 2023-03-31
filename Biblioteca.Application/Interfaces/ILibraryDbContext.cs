using Biblioteca.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Biblioteca.Application.Interfaces
{
    public interface ILibraryDbContext
    {
        DatabaseFacade Database { get; }
        DbSet<Book> Books { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        Task CommitTransactionAsync();
        void RollbackTransaction();
    }
}
