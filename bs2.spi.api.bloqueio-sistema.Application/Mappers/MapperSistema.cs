using pbox.api.sistemas.Application.Dto;
using pbox.api.sistemas.Application.Interfaces.Mappers;
using pbox.api.sistemas.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace pbox.api.sistemas.Application.Mappers
{
    public class MapperSistema : IMapperSistema
    {
        public Sistema MapperDtoToEntity(SistemaDto sistemaDto)
        {
            var sistema = new Sistema()
            {
                SistemaId = sistemaDto.SistemaId,
                Status = sistemaDto.Status,
                Motivo = sistemaDto.Motivo,
                Usuario = sistemaDto.Usuario,
                DataHoraCriacao = sistemaDto.DataHoraCriacao,
                DataHoraAtualizado = sistemaDto.DataHoraAtualizado,
                Codigo = sistemaDto.Codigo,
                Nome = sistemaDto.Nome,
                Descricao = sistemaDto.Descricao
            };
            return sistema;
        }

        public SistemaDto MapperEntityToDto(Sistema sistema)
        {
            var sistemaDto = new SistemaDto()
            {
                SistemaId = sistema.SistemaId,
                Status = sistema.Status,
                Motivo = sistema.Motivo,
                Usuario = sistema.Usuario,
                DataHoraCriacao = sistema.DataHoraCriacao,
                DataHoraAtualizado = sistema.DataHoraAtualizado,
                Codigo = sistema.Codigo,
                Nome = sistema.Nome,
                Descricao = sistema.Descricao
            };
            return sistemaDto;
        }

        public IEnumerable<SistemaDto> MapperListSistemaDto(IEnumerable<Sistema> sistemas)
        {
            var dto = sistemas.Select(c => new SistemaDto
            {
                SistemaId = c.SistemaId,
                Status = c.Status,
                Motivo = c.Motivo,
                Usuario = c.Usuario,
                DataHoraCriacao = c.DataHoraCriacao,
                DataHoraAtualizado = c.DataHoraAtualizado,
                Codigo = c.Codigo,
                Nome = c.Nome,
                Descricao = c.Descricao
            });

            return dto;
        }
    }
}