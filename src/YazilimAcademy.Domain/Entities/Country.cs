using YazilimAcademy.Domain.Common;
using System.Text.Json.Serialization;
using YazilimAcademy.Domain.ValueObjects;

namespace YazilimAcademy.Domain.Entities
{
    public class Country : EntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Iso3 { get; set; } //ASK: ISO3 or ISO2 required?
        public string Iso2 { get; set; }
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
        public List<CountryTimeZone> Timezones { get; set; } = new List<CountryTimeZone>();
        public CountryTranslation Translations { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
