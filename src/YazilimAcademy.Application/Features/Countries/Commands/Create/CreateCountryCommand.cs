using MediatR;
using YazilimAcademy.Application.Common.Models.Responses;

namespace YazilimAcademy.Application.Features.Countries.Commands.Create;

public sealed record CreateCountryCommand(
    string Name, 
    string Iso2, 
    string? Iso3, 
    string? NumericCode, 
    string? PhoneCode, 
    string? Capital, 
    string? Currency, 
    string? CurrencyName, 
    string? CurrencySymbol, 
    string? Tld, 
    string? Native, 
    string? Region, 
    string? RegionId, 
    string? Subregion, 
    string? SubregionId, 
    string? Nationality, 
    double? Latitude, 
    double? Longitude, 
    string? Emoji, 
    string? EmojiU) : IRequest<ResponseDto<int>>;