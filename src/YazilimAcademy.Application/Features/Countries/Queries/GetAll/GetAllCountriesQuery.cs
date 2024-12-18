using MediatR;
using YazilimAcademy.Application.Common.Models.Pagination;
using YazilimAcademy.Application.Common.Models.Responses;

namespace YazilimAcademy.Application.Features.Countries.Queries.GetAll;

public sealed record GetAllCountriesQuery(int PageNumber, int PageSize) : IRequest<PaginatedList<GetAllCountriesDto>>; 