using Dapper;
using MediatR;
using YazilimAcademy.Application.Common.Interfaces;
using YazilimAcademy.Application.Common.Models.Pagination;
using YazilimAcademy.Application.Common.Models.Responses;

namespace YazilimAcademy.Application.Features.Cities.Queries.GetById;

public sealed class GetByIdCityQueryHandler : IRequestHandler<GetByIdCityQuery, PaginatedList<GetByIdCityDto>>
{
    private readonly ISqlConnectionFactory _sqlConnectionFactory;

    public GetByIdCityQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
    {
        _sqlConnectionFactory = sqlConnectionFactory;
    }

    public async Task<PaginatedList<GetByIdCityDto>> Handle(GetByIdCityQuery request, CancellationToken cancellationToken)
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

        var cities = (await multi.ReadAsync<GetByIdCityDto>()).ToList();

        return new PaginatedList<GetByIdCityDto>(cities, totalCount, request.PageNumber, request.PageSize);
    }
}