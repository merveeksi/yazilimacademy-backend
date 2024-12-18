using Dapper;
using MediatR;
using YazilimAcademy.Application.Common.Interfaces;
using YazilimAcademy.Application.Common.Models.Pagination;

namespace YazilimAcademy.Application.Features.Cities.Queries.GetAll;

public sealed class GetAllCitiesQueryHandler : IRequestHandler<GetAllCitiesQuery, PaginatedList<GetAllCitiesDto>>
{
    private readonly ISqlConnectionFactory _sqlConnectionFactory;

    public GetAllCitiesQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
    {
        _sqlConnectionFactory = sqlConnectionFactory;
    }

    public async Task<PaginatedList<GetAllCitiesDto>> Handle(GetAllCitiesQuery request, CancellationToken cancellationToken)
    {
        var connection = _sqlConnectionFactory.CreateConnection();

        var offset = (request.PageNumber - 1) * request.PageSize;
        var pageSize = request.PageSize;

        var sql = @"
        SELECT COUNT(*) FROM ""cities"";

        SELECT ""Id"", ""Name"", ""Latitude"", ""Longitude"", ""CountryId""
        FROM ""cities""
        ORDER BY ""Name""
        OFFSET @Offset LIMIT @PageSize;
    ";

        using var multi = await connection.QueryMultipleAsync(sql, new { Offset = offset, PageSize = pageSize });

        var totalCount = await multi.ReadSingleAsync<int>();

        var cities = (await multi.ReadAsync<GetAllCitiesDto>()).ToList();

        return new PaginatedList<GetAllCitiesDto>(cities, totalCount, request.PageNumber, request.PageSize);
    }
}
