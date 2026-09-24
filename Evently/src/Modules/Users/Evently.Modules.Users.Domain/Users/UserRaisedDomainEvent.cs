using Evently.Common.Domain;

namespace Evently.Modules.Users.Domain.Users;

public sealed class UserRaisedDomainEvent(Guid userId) : DomainEvent
{
    public Guid UserId { get; init; } = userId;
}