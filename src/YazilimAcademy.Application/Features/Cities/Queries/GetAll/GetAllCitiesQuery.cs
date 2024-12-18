using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using YazilimAcademy.Application.Common.Models.Pagination;

namespace YazilimAcademy.Application.Features.Cities.Queries.GetAll;

    public sealed record GetAllCitiesQuery(int PageNumber, int PageSize) : IRequest<PaginatedList<GetAllCitiesDto>>;