using MediatR;
using YazilimAcademy.Application.Common.Interfaces;
using YazilimAcademy.Application.Common.Models.Responses;
using YazilimAcademy.Domain.Entities;

namespace YazilimAcademy.Application.Features.Countries.Commands.Create;

public sealed class CreateCountryCommandHandler : IRequestHandler<CreateCountryCommand, ResponseDto<int>>
{
    private readonly IApplicationDbContext _dbContext;

    public CreateCountryCommandHandler(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ResponseDto<int>> Handle(CreateCountryCommand request, CancellationToken cancellationToken)
    {
        var country = Country.Create(0, request.Name, request.Iso2, request.Iso3, request.NumericCode, request.PhoneCode, request.Capital, request.Currency, request.CurrencyName, request.CurrencySymbol, request.Tld, request.Native, request.Region, request.RegionId, request.Subregion, request.SubregionId, request.Nationality, request.Latitude, request.Longitude, request.Emoji, request.EmojiU);

        _dbContext.Countries.Add(country);
        
        await _dbContext.SaveChangesAsync(cancellationToken);

        return ResponseDto<int>.Success(country.Id, "Ülke başarıyla oluşturuldu.");
    }
} 