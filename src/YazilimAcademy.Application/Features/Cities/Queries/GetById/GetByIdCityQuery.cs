using MediatR;
using YazilimAcademy.Application.Common.Models.Pagination;


namespace YazilimAcademy.Application.Features.Cities.Queries.GetById;

public sealed record GetByIdCityQuery(int PageNumber, int PageSize) : IRequest<PaginatedList<GetByIdCityDto>>;