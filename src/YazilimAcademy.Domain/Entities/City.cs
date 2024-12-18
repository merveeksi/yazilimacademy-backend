using YazilimAcademy.Domain.Common;

namespace YazilimAcademy.Domain.Entities
{
    public sealed class City : EntityBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }

        public static City Create(string name, double? latitude, double? longitude, int countryId)
        {
            return new City
            {
                Id = Guid.CreateVersion7(),
                Name = name,
                Latitude = latitude,
                Longitude = longitude,
                CountryId = countryId
            };
        }
    }
}
