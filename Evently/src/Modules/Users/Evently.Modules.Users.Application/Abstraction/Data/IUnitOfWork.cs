namespace Evently.Modules.Users.Application.Abstraction.Data;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}