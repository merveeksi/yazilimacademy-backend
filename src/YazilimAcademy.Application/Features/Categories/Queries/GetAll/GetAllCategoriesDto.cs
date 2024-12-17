namespace YazilimAcademy.Application.Features.Categories.Queries.GetAll;

public sealed record GetAllCategoriesDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public GetAllCategoriesDto(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}
