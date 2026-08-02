using Evently.Modules.Events.Application.Abstraction.Messaging;

namespace Evently.Modules.Events.Application.Events.SearchEvents;

public sealed record SearchEventQuery(
    Guid? CategoryId,
    DateTime? StartDate,
    DateTime? EndDate,
    int Page,
    int PageSize): IQuery<SearchEventsResponse>;