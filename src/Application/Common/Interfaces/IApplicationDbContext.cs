using CleanlinessTrimmed.Domain.Entities;

namespace CleanlinessTrimmed.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    DbSet<Account> Accounts { get; }
}
