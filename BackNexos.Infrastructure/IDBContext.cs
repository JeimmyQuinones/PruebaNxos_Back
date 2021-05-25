using BackNexos.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BackNexos.Infrastructure
{
    public interface IDBContext
    {
        DbSet<AuthorEntity> author { get; set; }
        DbSet<EditorialEntity> editorial { get; set; }
        DbSet<BookEntity> book { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        void RemoveRange(IEnumerable<object> entities);
        EntityEntry Update(object entity);
    }
}
