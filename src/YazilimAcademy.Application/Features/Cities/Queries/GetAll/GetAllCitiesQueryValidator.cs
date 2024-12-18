using FluentValidation;

namespace YazilimAcademy.Application.Features.Cities.Queries.GetAll
{
    public sealed class GetAllCitiesQueryValidator : AbstractValidator<GetAllCitiesQuery>
    {
        public GetAllCitiesQueryValidator()
        {
            RuleFor(x => x.PageNumber)
                .GreaterThan(0)
                .WithMessage("Sayfa numarası 1'den küçük olamaz.");

            RuleFor(x => x.PageSize)
                .GreaterThan(0)
                .WithMessage("Sayfa boyutu 1'den küçük olamaz.")
                .LessThan(100)
                .WithMessage("Sayfa boyutu 100'den büyük olamaz.");
        }
    }
}