using Evently.Modules.Events.Application.Abstraction.Messaging;

namespace Evently.Modules.Events.Application.Events.CancelEvent;

public sealed record CancelEventCommand(Guid EventId) : ICommand;