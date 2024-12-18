using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Validators;

namespace YazilimAcademy.Application.Features.Countries.Queries.GetAll
{
    public sealed class GetAllCountriesQueryValidator : AbstractValidator<GetAllCountriesQuery>
    {
        public GetAllCountriesQueryValidator()
        {
            RuleFor(c => c.PageNumber)
                .GreaterThan(0)
                .WithMessage("Page number must be greater than zero.");

            RuleFor(c => c.PageSize)
                .GreaterThan(0)
                .WithMessage("Page size must be greater than zero.");
        }
    }
}