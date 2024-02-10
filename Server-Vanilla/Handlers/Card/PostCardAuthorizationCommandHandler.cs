﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using ServerVanilla.Persistence;
using WebUIVanilla.Shared.Dto.Request;
using WebUIVanilla.Shared.Dto.Response;

namespace ServerVanilla.Handlers.Card;

public record PostCardAuthorizationCommand(CardAuthorizationRequest Request) : IRequest<BasicResponse>;

public class PostCardAuthorizationCommandHandler : IRequestHandler<PostCardAuthorizationCommand, BasicResponse>
{
    readonly ILogger _logger;
    readonly ServerDbContext _context;

    public PostCardAuthorizationCommandHandler(ILogger<PostCardAuthorizationCommandHandler> logger, ServerDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<BasicResponse> Handle(PostCardAuthorizationCommand request, CancellationToken cancellationToken)
    {
        var cardProfile = await _context.CardProfiles
            .Where(x => !x.IsNewCard)
            .FirstOrDefaultAsync(x => x.ChipId.Equals(request.Request.ChipId) && x.Id == request.Request.CardId);

        if (cardProfile is not null && request.Request.AccessCode == cardProfile.AccessCode)
            return new BasicResponse { Success = true };

        return new BasicResponse { Success = false };
    }
}
