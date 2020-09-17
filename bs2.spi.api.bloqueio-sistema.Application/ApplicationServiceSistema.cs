using pbox.api.sistemas.Application.Dto;
using pbox.api.sistemas.Application.Interfaces;
using pbox.api.sistemas.Application.Interfaces.Mappers;
using pbox.api.sistemas.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace pbox.api.sistemas.Application
{
    public class ApplicationServiceSistema : IApplicationServiceSistema
    {
        private readonly IServiceSistema serviceSistema;
        private readonly IMapperSistema mapperSistema;

        public ApplicationServiceSistema(IServiceSistema serviceSistema, IMapperSistema mapperSistema)
        {
            this.serviceSistema = serviceSistema;
            this.mapperSistema = mapperSistema;
        }

        public void Add(SistemaDto sistemaDto)
        {
            var sistema = mapperSistema.MapperDtoToEntity(sistemaDto);
            serviceSistema.Add(sistema);
        }

        public IEnumerable<SistemaDto> GetAll()
        {
            var sistemas = serviceSistema.GetAll();
            return mapperSistema.MapperListSistemaDto(sistemas);
        }

        public SistemaDto GetById(Guid sistemaId)
        {
            var sistema = serviceSistema.GetById(sistemaId);

            if (sistema != null)
            {
                return mapperSistema.MapperEntityToDto(sistema);
            }

            return null;
        }

        public void Remove(SistemaDto sistemaDto)
        {
            var sistema = mapperSistema.MapperDtoToEntity(sistemaDto);
            serviceSistema.Remove(sistema);
        }

        public void Update(SistemaDto sistemaDto)
        {
            var sistema = mapperSistema.MapperDtoToEntity(sistemaDto);
            serviceSistema.Update(sistema);
        }
    }
}