using Dapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using YazilimAcademy.Application.Common.Interfaces;
using YazilimAcademy.Application.Common.Models.Pagination;
using YazilimAcademy.Application.Common.Models.Responses;

namespace YazilimAcademy.Application.Features.Countries.Queries.GetById;

public sealed class GetByIdCountryQueryHandler : IRequestHandler<GetByIdCountryQuery, PaginatedList<GetByIdCountryDto>>
{
    private readonly ISqlConnectionFactory _sqlConnectionFactory;

    public GetByIdCountryQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
    {
        _sqlConnectionFactory = sqlConnectionFactory;
    }

    public async Task<PaginatedList<GetByIdCountryDto>> Handle(GetByIdCountryQuery request, CancellationToken cancellationToken)
    {
        var connection = _sqlConnectionFactory.CreateConnection();

        var offset = (request.PageNumber - 1) * request.PageSize;
        var pageSize = request.PageSize;

        var sql = @"
            SELECT COUNT(*) FROM ""Countries"";

            SELECT ""Id"", ""Name"", ""Iso2"", ""Iso3"", ""NumericCode"", ""PhoneCode"", ""Capital"", ""Currency"", 
                   ""CurrencyName"", ""CurrencySymbol"", ""Tld"", ""Native"", ""Region"", ""RegionId"", 
                   ""Subregion"", ""SubregionId"", ""Nationality"", ""Latitude"", ""Longitude"", 
                   ""Emoji"", ""EmojiU""
            FROM ""Countries""
            ORDER BY ""Name""
            OFFSET @Offset LIMIT @PageSize;
        ";
        
        using var multi = await connection.QueryMultipleAsync(sql, new { Offset = offset, PageSize = pageSize });

        var totalCount = await multi.ReadSingleAsync<int>();
        var countries = (await multi.ReadAsync<GetByIdCountryDto>()).ToList();

        return new PaginatedList<GetByIdCountryDto>(countries, totalCount, request.PageNumber, request.PageSize);
    }
} 