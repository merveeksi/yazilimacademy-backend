using MediatR;
using YazilimAcademy.Application.Common.Models.Responses;

namespace YazilimAcademy.Application.Features.Cities.Commands.Create;

public sealed record CreateCityCommand(string Name, string Description, double? Latitude, double? Longitude, int CountryId) : IRequest<ResponseDto<Guid>>;