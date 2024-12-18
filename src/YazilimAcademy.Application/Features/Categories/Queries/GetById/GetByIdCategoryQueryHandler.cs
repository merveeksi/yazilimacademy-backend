using Dapper;
using MediatR;
using YazilimAcademy.Application.Common.Interfaces;
using YazilimAcademy.Application.Common.Models.Pagination;

namespace YazilimAcademy.Application.Features.Categories.Queries.GetById;

public sealed class
    GetByIdCategoryQueryHandler : IRequestHandler<GetByIdCategoryQuery, PaginatedList<GetByIdCategoryDto>>
{
    private readonly ISqlConnectionFactory _sqlConnectionFactory;

    public GetByIdCategoryQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
    {
        _sqlConnectionFactory = sqlConnectionFactory;
    }

    public async Task<PaginatedList<GetByIdCategoryDto>> Handle(GetByIdCategoryQuery request,
        CancellationToken cancellationToken)
    {
        var connection = _sqlConnectionFactory.CreateConnection();

        var offset = (request.PageNumber - 1) * request.PageSize;
        var pageSize = request.PageSize;

        var sql = @"
            SELECT COUNT(*) FROM ""categories"";

            SELECT ""Id"", ""Name""
            FROM ""categories""
            ORDER BY ""Name""
            OFFSET @Offset LIMIT @PageSize;
        ";

        using var multi = await connection.QueryMultipleAsync(sql, new { Offset = offset, PageSize = pageSize });

        var totalCount = await multi.ReadSingleAsync<int>();

        var categories = (await multi.ReadAsync<GetByIdCategoryDto>()).ToList();

        return new PaginatedList<GetByIdCategoryDto>(categories, totalCount, request.PageNumber, request.PageSize);
    }
}