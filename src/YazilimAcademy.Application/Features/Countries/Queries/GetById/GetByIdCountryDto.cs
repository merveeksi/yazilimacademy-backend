namespace YazilimAcademy.Application.Features.Countries.Queries.GetById;

public sealed record GetByIdCountryDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Iso2 { get; set; }
    public string? Iso3 { get; set; }
    public string? NumericCode { get; set; }
    public string? PhoneCode { get; set; }
    public string? Capital { get; set; }
    public string? Currency { get; set; }
    public string? CurrencyName { get; set; }
    public string? CurrencySymbol { get; set; }
    public string? Tld { get; set; }
    public string? Native { get; set; }
    public string? Region { get; set; }
    public string? RegionId { get; set; }
    public string? Subregion { get; set; }
    public string? SubregionId { get; set; }
    public string? Nationality { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    public string? Emoji { get; set; }
    public string? EmojiU { get; set; }

    public GetByIdCountryDto(int id, string name, string iso2, string? iso3, string? numericCode, string? phoneCode,
        string? capital, string? currency, string? currencyName, string? currencySymbol, string? tld,
        string? native, string? region, string? regionId, string? subregion, string? subregionId, string? nationality,
        double? latitude, double? longitude, string? emoji, string? emojiU)
    {
        Id = id;
        Name = name;
        Iso2 = iso2;
        Iso3 = iso3;
        NumericCode = numericCode;
        PhoneCode = phoneCode;
        Capital = capital;
        Currency = currency;
        CurrencyName = currencyName;
        CurrencySymbol = currencySymbol;
        Tld = tld;
        Native = native;
        Region = region;
        RegionId = regionId;
        Subregion = subregion;
        SubregionId = subregionId;
        Nationality = nationality;
        Latitude = latitude;
        Longitude = longitude;
        Emoji = emoji;
        EmojiU = emojiU;
    }
}