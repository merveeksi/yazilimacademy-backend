using MediatR;
using YazilimAcademy.Application.Common.Models.Pagination;

namespace YazilimAcademy.Application.Features.Categories.Queries.GetById;

public sealed record GetByIdCategoryQuery(int PageNumber, int PageSize) : IRequest<PaginatedList<GetByIdCategoryDto>>;