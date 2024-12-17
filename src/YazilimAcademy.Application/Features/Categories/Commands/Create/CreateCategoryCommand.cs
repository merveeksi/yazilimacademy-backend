using MediatR;
using YazilimAcademy.Application.Common.Models.Responses;

namespace YazilimAcademy.Application.Features.Categories.Commands.Create;

public sealed record CreateCategoryCommand(string Name, string Description) : IRequest<ResponseDto<Guid>>;
