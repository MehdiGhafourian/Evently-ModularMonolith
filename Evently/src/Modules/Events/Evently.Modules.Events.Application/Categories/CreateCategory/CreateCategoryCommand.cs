using Evently.Modules.Events.Application.Abstraction.Messaging;

namespace Evently.Modules.Events.Application.Categories.CreateCategory;

public sealed record CreateCategoryCommand(string Name) : ICommand<Guid>;