using pbox.api.sistemas.Application.Dto;
using pbox.api.sistemas.Domain.Entities;
using System.Collections.Generic;

namespace pbox.api.sistemas.Application.Interfaces.Mappers
{
    public interface IMapperSistemaLog
    {
        SistemaLog MapperDtoToEntity(SistemaLogDto sistemaLogDto);

        IEnumerable<SistemaLogDto> MapperListSistemaLogDto(IEnumerable<SistemaLog> sistemaLogs);

        SistemaLogDto MapperEntityToDto(SistemaLog sistemaLog);
    }
}