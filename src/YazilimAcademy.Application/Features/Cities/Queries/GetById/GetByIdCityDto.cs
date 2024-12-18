namespace YazilimAcademy.Application.Features.Cities.Queries.GetById;

public sealed record GetByIdCityDto
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public double? Latitude { get; init; }
    public double? Longitude { get; init; }
    public int CountryId { get; init; }

    public GetByIdCityDto(Guid id, string name, double? latitude, double? longitude, int countryId)
    {
        Id = id;
        Name = name;
        Latitude = latitude;
        Longitude = longitude;
        CountryId = countryId;
    }
} 