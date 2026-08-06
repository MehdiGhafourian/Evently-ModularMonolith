using Evently.Common.Domain;
namespace Evently.Common.Application.Exceptions;

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