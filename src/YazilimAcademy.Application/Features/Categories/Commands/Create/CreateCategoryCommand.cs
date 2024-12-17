using MediatR;

namespace YazilimAcademy.Application.Features.Categories.Commands.Create;

public sealed record CreateCategoryCommand(string Name, string Description) : IRequest<Guid>;
