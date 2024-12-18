using MediatR;
using YazilimAcademy.Application.Common.Interfaces;
using YazilimAcademy.Application.Common.Models.Responses;
using YazilimAcademy.Domain.Entities;

namespace YazilimAcademy.Application.Features.Categories.Commands.Create;

public sealed class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, ResponseDto<Guid>>
{
    private readonly IApplicationDbContext _dbContext;

    public CreateCategoryCommandHandler(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ResponseDto<Guid>> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = Category.Create(request.Name, request.Description);

        _dbContext.Categories.Add(category);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return ResponseDto<Guid>.Success(category.Id, "Kategori başarıyla oluşturuldu.");
    }
}
