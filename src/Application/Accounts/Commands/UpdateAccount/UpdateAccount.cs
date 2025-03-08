using CleanlinessTrimmed.Application.Common.Interfaces;

namespace CleanlinessTrimmed.Application.Accounts.Commands.UpdateAccount;

public record UpdateAccountCommand : IRequest
{
}

public class UpdateAccountCommandValidator : AbstractValidator<UpdateAccountCommand>
{
    public UpdateAccountCommandValidator()
    {
    }
}

public class UpdateAccountCommandHandler : IRequestHandler<UpdateAccountCommand>
{
    private readonly IApplicationDbContext _context;

    public UpdateAccountCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task Handle(UpdateAccountCommand request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
    }
}
