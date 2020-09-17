using pbox.api.sistemas.Application.Dto;
using pbox.api.sistemas.Application.Interfaces.Mappers;
using pbox.api.sistemas.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace pbox.api.sistemas.Application.Mappers
{
    public class MapperSistemaLog : IMapperSistemaLog
    {
        public SistemaLog MapperDtoToEntity(SistemaLogDto sistemaLogDto)
        {
            var sistemaLog = new SistemaLog()
            {
                SistemaId = sistemaLogDto.SistemaId,
                Status = sistemaLogDto.Status,
                Motivo = sistemaLogDto.Motivo,
                Usuario = sistemaLogDto.Usuario,
                DataHoraCriacao = sistemaLogDto.DataHoraCriacao
            };
            return sistemaLog;
        }

        public SistemaLogDto MapperEntityToDto(SistemaLog sistemaLog)
        {
            var sistemaLogDto = new SistemaLogDto()
            {
                SistemaId = sistemaLog.SistemaId,
                Status = sistemaLog.Status,
                Motivo = sistemaLog.Motivo,
                Usuario = sistemaLog.Usuario,
                DataHoraCriacao = sistemaLog.DataHoraCriacao
            };
            return sistemaLogDto;
        }

        public IEnumerable<SistemaLogDto> MapperListSistemaLogDto(IEnumerable<SistemaLog> sistemaLogs)
        {
            var dto = sistemaLogs.Select(c => new SistemaLogDto
            {
                SistemaId = c.SistemaId,
                Status = c.Status,
                Motivo = c.Motivo,
                Usuario = c.Usuario,
                DataHoraCriacao = c.DataHoraCriacao
            });

            return dto;
        }
    }
}