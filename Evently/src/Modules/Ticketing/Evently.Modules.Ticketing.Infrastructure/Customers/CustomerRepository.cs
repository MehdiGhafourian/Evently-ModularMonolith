using Evently.Modules.Ticketing.Domain.Customers;

namespace Evently.Modules.Ticketing.Infrastructure.Customers;

internal sealed class CustomerRepository : ICustomerRepository
{
    public Task<Customer?> GetAsync(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void Insert(Customer customer)
    {
        throw new NotImplementedException();
    }
}