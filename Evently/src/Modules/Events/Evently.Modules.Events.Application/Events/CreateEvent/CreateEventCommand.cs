using Evently.Modules.Events.Domain.Abstractions;
using MediatR;

namespace Evently.Modules.Events.Application.Events.CreateEvent;

public sealed record CreateEventCommand(
    Guid CategoryId,
    string Title,
    string Description,
    string Location,
    DateTime StartsAtUtc,
    DateTime? EndsAtUtc
) : IRequest<Result<Guid>>;