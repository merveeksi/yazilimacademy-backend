using MediatR;
using YazilimAcademy.Application.Common.Models.Pagination;
using YazilimAcademy.Application.Common.Models.Responses;

namespace YazilimAcademy.Application.Features.Countries.Queries.GetById;

public sealed record GetByIdCountryQuery(int PageNumber, int PageSize) : IRequest<PaginatedList<GetByIdCountryDto>>; 