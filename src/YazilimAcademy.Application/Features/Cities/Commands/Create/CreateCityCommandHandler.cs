using MediatR;
using YazilimAcademy.Application.Common.Interfaces;
using YazilimAcademy.Application.Common.Models.Responses;
using YazilimAcademy.Domain.Entities;

namespace YazilimAcademy.Application.Features.Cities.Commands.Create;

public sealed class CreateCityCommandHandler : IRequestHandler<CreateCityCommand, ResponseDto<Guid>>
{
    private readonly IApplicationDbContext _dbContext;

    public CreateCityCommandHandler(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ResponseDto<Guid>> Handle(CreateCityCommand request, CancellationToken cancellationToken)
    {
        var city = City.Create(request.Name, request.Latitude, request.Longitude, request.CountryId);

        _dbContext.Cities.Add(city);
        
        await _dbContext.SaveChangesAsync(cancellationToken);

        return ResponseDto<Guid>.Success(city.Id, "Şehir başarıyla oluşturuldu.");
    }
}