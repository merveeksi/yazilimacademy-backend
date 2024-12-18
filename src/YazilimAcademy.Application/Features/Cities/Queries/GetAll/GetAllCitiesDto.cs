namespace YazilimAcademy.Application.Features.Cities.Queries.GetAll;
    public sealed record GetAllCitiesDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int CountryId { get; set; }

        public GetAllCitiesDto(Guid id, string name, double? latitude, double? longitude, int countryId)
        {
            Id = id;
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
            CountryId = countryId;
        }
    }
