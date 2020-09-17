using pbox.api.sistemas.Application.Dto;
using pbox.api.sistemas.Domain.Entities;
using System.Collections.Generic;

namespace pbox.api.sistemas.Application.Interfaces.Mappers
{
    public interface IMapperSistema
    {
        Sistema MapperDtoToEntity(SistemaDto sistemaDto);

        IEnumerable<SistemaDto> MapperListSistemaDto(IEnumerable<Sistema> sistemas);

        SistemaDto MapperEntityToDto(Sistema sistema);
    }
}