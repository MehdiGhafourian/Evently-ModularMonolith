using Evently.Modules.Events.Domain.Abstractions;

namespace Evently.Modules.Events.Application.Abstraction.Exceptions;

public class EventlyException : Exception
{
    public string RequestName { get; }
    public Error? Error { get; }

    public EventlyException(string requestName, Error? error = default, Exception? innerException = default)
    {
        RequestName = requestName;
        Error = error;
    }
}