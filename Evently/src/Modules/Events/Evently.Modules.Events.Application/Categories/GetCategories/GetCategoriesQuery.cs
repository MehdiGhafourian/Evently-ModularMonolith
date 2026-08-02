using Evently.Modules.Events.Application.Abstraction.Messaging;
using Evently.Modules.Events.Application.Categories.GetCategory;

namespace Evently.Modules.Events.Application.Categories.GetCategories;

internal sealed record GetCategoriesQuery : IQuery<IReadOnlyCollection<CategoryResponse>>;