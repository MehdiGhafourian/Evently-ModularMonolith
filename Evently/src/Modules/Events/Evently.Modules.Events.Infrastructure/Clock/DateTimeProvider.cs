using Evently.Modules.Events.Application.Abstraction.Clock;

namespace Evently.Modules.Events.Infrastructure.Clock;

internal sealed class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}