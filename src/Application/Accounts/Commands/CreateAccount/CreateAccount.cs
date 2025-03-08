using System.Runtime.InteropServices;
using CleanlinessTrimmed.Application.Common.Interfaces;
using CleanlinessTrimmed.Domain.Entities;

namespace CleanlinessTrimmed.Application.Accounts.Commands.CreateAccount;

public record CreateAccountCommand : IRequest<int>
{
    public string Name { get; set; } = string.Empty;
}

public class CreateAccountCommandValidator : AbstractValidator<CreateAccountCommand>
{
    public CreateAccountCommandValidator()
    {
    }
}

public class CreateAccountCommandHandler : IRequestHandler<CreateAccountCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateAccountCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
    {
        var entity = new Account();
        
        entity.Name = request.Name;

        _context.Accounts.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}
