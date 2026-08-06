using Evently.Common.Domain;

namespace Evently.Modules.Events.Domain.TicketTypes;

public sealed class TicketTypePriceChangeDomainEvent(Guid ticketTypeId, decimal price) : DomainEvent
{
    public Guid TicketTypeId { get; init; } = ticketTypeId;

    public decimal Price { get; init; } = price;
}