using System;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using YazilimAcademy.Application.Common.Interfaces;
namespace YazilimAcademy.Application.Features.Categories.Commands.Create;

public sealed class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
{
    private readonly IApplicationDbContext _dbContext;

    public CreateCategoryCommandValidator(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;

        RuleFor(c => c.Name)
        .NotEmpty()
        .WithMessage("Kategori adı boş olamaz.")
        .MaximumLength(100)
        .WithMessage("Kategori adı en fazla 100 karakter olmalıdır.")
        .MinimumLength(3)
        .WithMessage("Kategori adı en az 3 karakter olmalıdır.");

        RuleFor(c => c.Description)
        .NotEmpty()
        .When(c => !string.IsNullOrWhiteSpace(c.Description))
        .WithMessage("Kategori açıklaması boş olamaz.")
        .MaximumLength(1000)
        .WithMessage("Kategori açıklaması en fazla 1000 karakter olmalıdır.")
        .MinimumLength(10)
        .WithMessage("Kategori açıklaması en az 10 karakter olmalıdır.");

        RuleFor(c => c.Name)
        .MustAsync(IsCategoryNameUniqueAsync)
        .WithMessage("Bu kategori adı zaten mevcuttur.");
    }

    private async Task<bool> IsCategoryNameUniqueAsync(string name, CancellationToken cancellationToken)
    {
        return !await _dbContext
        .Categories
        .AnyAsync(c => c.Name.ToLower() == name.ToLower(), cancellationToken);
    }
}
