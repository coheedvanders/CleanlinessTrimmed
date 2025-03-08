using System.Reflection.Metadata.Ecma335;
using CleanlinessTrimmed.Application.Common.Interfaces;

namespace CleanlinessTrimmed.Application.Accounts.Queries.GetAccountList;

public record GetAccountListQuery : IRequest<List<AccountDto>>
{
    public string SearchName { get; set; } = string.Empty;
}

public class GetAccountListQueryValidator : AbstractValidator<GetAccountListQuery>
{
    public GetAccountListQueryValidator()
    {
    }
}

public class GetAccountListQueryHandler : IRequestHandler<GetAccountListQuery, List<AccountDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetAccountListQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<AccountDto>> Handle(GetAccountListQuery request, CancellationToken cancellationToken)
    {
        var result = await _context.
                                Accounts
                                .ProjectTo<AccountDto>(_mapper.ConfigurationProvider)
                                .ToListAsync();
        return result;
    }
}
