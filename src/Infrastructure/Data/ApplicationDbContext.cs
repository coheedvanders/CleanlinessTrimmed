using System.Reflection;
using CleanlinessTrimmed.Application.Common.Interfaces;
using CleanlinessTrimmed.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanlinessTrimmed.Infrastructure.Data;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Account> Accounts => Set<Account>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
