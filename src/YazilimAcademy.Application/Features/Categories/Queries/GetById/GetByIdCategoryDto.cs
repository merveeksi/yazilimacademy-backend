namespace YazilimAcademy.Application.Features.Categories.Queries.GetById;

public sealed record GetByIdCategoryDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public GetByIdCategoryDto(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}