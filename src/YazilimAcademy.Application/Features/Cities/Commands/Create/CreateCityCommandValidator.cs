using FluentValidation;
using Microsoft.EntityFrameworkCore;
using YazilimAcademy.Application.Common.Interfaces;

namespace YazilimAcademy.Application.Features.Cities.Commands.Create;

public sealed class CreateCityCommandValidator : AbstractValidator<CreateCityCommand>
{
    private readonly IApplicationDbContext _dbContext;

    public CreateCityCommandValidator(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;

        RuleFor(c => c.Name)
            .NotEmpty()
            .WithMessage("Şehir adı boş olamaz.")
            .MaximumLength(100)
            .WithMessage("Şehir adı en fazla 100 karakter olmalıdır.")
            .MinimumLength(2)
            .WithMessage("Şehir adı en az 2 karakter olmalıdır.");

        RuleFor(c => c.Description)
            .NotEmpty()
            .When(c => !string.IsNullOrWhiteSpace(c.Description))
            .WithMessage("Şehir açıklaması boş olamaz.")
            .MaximumLength(1000)
            .WithMessage("Şehir açıklaması en fazla 1000 karakter olmalıdır.")
            .MinimumLength(10)
            .WithMessage("Şehir açıklaması en az 10 karakter olmalıdır.");

        RuleFor(c => c.CountryId)
            .NotEmpty()
            .WithMessage("Ülke ID'si boş olamaz.")
            .MustAsync(DoesCountryExistAsync)
            .WithMessage("Belirtilen ülke bulunamadı.");

    }

    private async Task<bool> DoesCountryExistAsync(int countryId, CancellationToken cancellationToken)
    {
        return await _dbContext.Countries
            .AnyAsync(c => c.Id == countryId, cancellationToken);
    }


}