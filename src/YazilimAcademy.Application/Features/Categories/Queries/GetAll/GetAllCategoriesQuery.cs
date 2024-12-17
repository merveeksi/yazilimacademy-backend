using MediatR;
using YazilimAcademy.Application.Common.Models.Pagination;

namespace YazilimAcademy.Application.Features.Categories.Queries.GetAll;

public sealed record GetAllCategoriesQuery(int PageNumber, int PageSize) : IRequest<PaginatedList<GetAllCategoriesDto>>;