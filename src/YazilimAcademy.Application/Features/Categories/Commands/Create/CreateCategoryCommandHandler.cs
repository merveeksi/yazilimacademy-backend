using System;
using MediatR;
using YazilimAcademy.Application.Common.Interfaces;
using YazilimAcademy.Domain.Entities;

namespace YazilimAcademy.Application.Features.Categories.Commands.Create;

public sealed class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, Guid>
{
    private readonly IApplicationDbContext _dbContext;

    public CreateCategoryCommandHandler(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Guid> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = Category.Create(request.Name, request.Description);

        _dbContext.Categories.Add(category);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return category.Id;
    }
}
