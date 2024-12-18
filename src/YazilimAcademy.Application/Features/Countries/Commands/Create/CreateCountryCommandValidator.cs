using FluentValidation;
using YazilimAcademy.Application.Common.Interfaces;

namespace YazilimAcademy.Application.Features.Countries.Commands.Create;

public sealed class CreateCountryCommandValidator : AbstractValidator<CreateCountryCommand>
{
    private readonly IApplicationDbContext _dbContext;

    public CreateCountryCommandValidator(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;

        RuleFor(c => c.Name)
            .NotEmpty()
            .WithMessage("Ülke adı boş olamaz.")
            .MaximumLength(100)
            .WithMessage("Ülke adı en fazla 100 karakter olmalıdır.")
            .MinimumLength(2)
            .WithMessage("Ülke adı en az 2 karakter olmalıdır.");

        RuleFor(c => c.Iso2)
            .NotEmpty()
            .WithMessage("Ülke kodu boş olamaz.")
            .MaximumLength(2)
            .WithMessage("Ülke kodu en fazla 2 karakter olmalıdır.")
            .MinimumLength(2)
            .WithMessage("Ülke kodu en az 2 karakter olmalıdır.");

        RuleFor(c => c.Iso3)
            .NotEmpty()
            .WithMessage("ISO3 kodu boş olamaz.")
            .MaximumLength(3)
            .WithMessage("ISO3 kodu en fazla 3 karakter olmalıdır.")
            .MinimumLength(3)
            .WithMessage("ISO3 kodu en az 3 karakter olmalıdır.");

        RuleFor(c => c.NumericCode)
            .NotEmpty()
            .WithMessage("Sayısal kod boş olamaz.")
            .MaximumLength(5)
            .WithMessage("Sayısal kod en fazla 5 karakter olmalıdır.")
            .MinimumLength(1)
            .WithMessage("Sayısal kod en az 1 karakter olmalıdır.")
            .Matches("^[0-9]*$")
            .WithMessage("Sayısal kod sadece rakamlardan oluşmalıdır.");

        RuleFor(c => c.PhoneCode)
            .NotEmpty()
            .WithMessage("Telefon kodu boş olamaz.")
            .MaximumLength(5)
            .WithMessage("Telefon kodu en fazla 5 karakter olmalıdır.")
            .MinimumLength(1)
            .WithMessage("Telefon kodu en az 1 karakter olmalıdır.")
            .Matches("^[+0-9]*$")
            .WithMessage("Telefon kodu sadece rakamlar ve '+' işareti içerebilir.");

        RuleFor(c => c.Capital)
            .NotEmpty()
            .WithMessage("Başkent adı boş olamaz.")
            .MaximumLength(100)
            .WithMessage("Başkent adı en fazla 100 karakter olmalıdır.")
            .MinimumLength(2)
            .WithMessage("Başkent adı en az 2 karakter olmalıdır.");

        RuleFor(c => c.Currency)
            .NotEmpty()
            .WithMessage("Para birimi boş olamaz.")
            .MaximumLength(50)
            .WithMessage("Para birimi en fazla 50 karakter olmalıdır.")
            .MinimumLength(1)
            .WithMessage("Para birimi en az 1 karakter olmalıdır.");

        RuleFor(c => c.CurrencyName)
            .NotEmpty()
            .WithMessage("Para birimi adı boş olamaz.")
            .MaximumLength(50)
            .WithMessage("Para birimi adı en fazla 50 karakter olmalıdır.")
            .MinimumLength(1)
            .WithMessage("Para birimi adı en az 1 karakter olmalıdır.");

        RuleFor(c => c.CurrencySymbol)
            .NotEmpty()
            .WithMessage("Para birimi sembolü boş olamaz.")
            .MaximumLength(10)
            .WithMessage("Para birimi sembolü en fazla 10 karakter olmalıdır.")
            .MinimumLength(1)
            .WithMessage("Para birimi sembolü en az 1 karakter olmalıdır.");

        RuleFor(c => c.Tld)
            .NotEmpty()
            .WithMessage("TLD boş olamaz.")
            .MaximumLength(10)
            .WithMessage("TLD en fazla 10 karakter olmalıdır.")
            .MinimumLength(1)
            .WithMessage("TLD en az 1 karakter olmalıdır.");

        RuleFor(c => c.Native)
            .NotEmpty()
            .WithMessage("Yerel adı boş olamaz.")
            .MaximumLength(100)
            .WithMessage("Yerel adı en fazla 100 karakter olmalıdır.")
            .MinimumLength(2)
            .WithMessage("Yerel adı en az 2 karakter olmalıdır.");

        RuleFor(c => c.Region)
            .NotEmpty()
            .WithMessage("Bölge adı boş olamaz.")
            .MaximumLength(100)
            .WithMessage("Bölge adı en fazla 100 karakter olmalıdır.")
            .MinimumLength(2)
            .WithMessage("Bölge adı en az 2 karakter olmalıdır.");

        RuleFor(c => c.RegionId)
            .NotEmpty()
            .WithMessage("Bölge ID boş olamaz.")
            .Must(id => int.TryParse(id.ToString(), out var result) && result > 0)
            .WithMessage("Bölge ID sadece pozitif sayılar olmalıdır.");

        RuleFor(c => c.Subregion)
            .NotEmpty()
            .WithMessage("Alt bölge adı boş olamaz.")
            .MaximumLength(100)
            .WithMessage("Alt bölge adı en fazla 100 karakter olmalıdır.")
            .MinimumLength(2)
            .WithMessage("Alt bölge adı en az 2 karakter olmalıdır.");

        RuleFor(c => c.SubregionId)
            .NotEmpty()
            .WithMessage("Alt bölge ID boş olamaz.")
            .Must(id => int.TryParse(id.ToString(), out var result) && result > 0)
            .WithMessage("Alt bölge ID sadece pozitif sayılar olmalıdır.");

        RuleFor(c => c.Nationality)
            .NotEmpty()
            .WithMessage("Milliyet boş olamaz.")
            .MaximumLength(50)
            .WithMessage("Milliyet en fazla 50 karakter olmalıdır.")
            .MinimumLength(1)
            .WithMessage("Milliyet en az 1 karakter olmalıdır.");

        RuleFor(c => c.Latitude)
            .NotNull()
            .WithMessage("Enlem boş olamaz.");

        RuleFor(c => c.Longitude)
            .NotNull()
            .WithMessage("Boylam boş olamaz.");

        RuleFor(c => c.Emoji)
            .MaximumLength(10)
            .WithMessage("Emoji en fazla 10 karakter olmalıdır.");

        RuleFor(c => c.EmojiU)
            .MaximumLength(10)
            .WithMessage("EmojiU en fazla 10 karakter olmalıdır.");
    }
} 