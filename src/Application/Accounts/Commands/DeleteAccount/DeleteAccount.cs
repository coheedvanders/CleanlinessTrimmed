using CleanlinessTrimmed.Application.Common.Interfaces;

namespace CleanlinessTrimmed.Application.Accounts.Commands.DeleteAccount;

public record DeleteAccountCommand : IRequest
{
}

public class DeleteAccountCommandValidator : AbstractValidator<DeleteAccountCommand>
{
    public DeleteAccountCommandValidator()
    {
    }
}

public class DeleteAccountCommandHandler : IRequestHandler<DeleteAccountCommand>
{
    private readonly IApplicationDbContext _context;

    public DeleteAccountCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task Handle(DeleteAccountCommand request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
    }
}
