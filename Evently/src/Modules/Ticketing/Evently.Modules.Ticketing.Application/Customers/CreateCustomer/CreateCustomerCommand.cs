using Evently.Common.Application.Messaging;

namespace Evently.Modules.Ticketing.Application.Customers.CreateCustomer;

public record CreateCustomerCommand(Guid CustomerId, string Email, string FirstName, string LastName): ICommand;