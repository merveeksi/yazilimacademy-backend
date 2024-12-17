using YazilimAcademy.Domain.Common;

namespace YazilimAcademy.Domain.Entities
{
    public class City : EntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
