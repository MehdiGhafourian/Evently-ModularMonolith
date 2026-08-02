namespace Evently.Modules.Events.Application.Abstraction.Clock;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}