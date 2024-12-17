namespace YazilimAcademy.Domain.ValueObjects;

public sealed class CountryTimeZone
{
    public string ZoneName { get; set; }
    public int GmtOffset { get; set; }
    public string GmtOffsetName { get; set; }
    public string Abbreviation { get; set; }
    public string TzName { get; set; }
}
