using pbox.api.sistemas.Application.Dto;
using pbox.api.sistemas.Application.Interfaces;
using pbox.api.sistemas.Application.Interfaces.Mappers;
using pbox.api.sistemas.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace pbox.api.sistemas.Application
{
    public class ApplicationServiceSistemaLog : IApplicationServiceSistemaLog
    {
        private readonly IServiceSistemaLog serviceSistemaLog;
        private readonly IMapperSistemaLog mapperSistemaLog;

        public void Add(SistemaLogDto sistemaLogDto)
        {
            var sistema = mapperSistemaLog.MapperDtoToEntity(sistemaLogDto);
            serviceSistemaLog.Add(sistema);
        }

        public IEnumerable<SistemaLogDto> GetAll()
        {
            var sistemaLogs = serviceSistemaLog.GetAll();
            return mapperSistemaLog.MapperListSistemaLogDto(sistemaLogs);
        }

        public SistemaLogDto GetById(Guid sistemaId)
        {
            var sistemaLog = serviceSistemaLog.GetById(sistemaId);
            return mapperSistemaLog.MapperEntityToDto(sistemaLog);
        }

        public void Remove(SistemaLogDto sistemaLogDto)
        {
            var sistemaLog = mapperSistemaLog.MapperDtoToEntity(sistemaLogDto);
            serviceSistemaLog.Remove(sistemaLog);
        }

        public void Update(SistemaLogDto sistemaLogDto)
        {
            var sistemaLog = mapperSistemaLog.MapperDtoToEntity(sistemaLogDto);
            serviceSistemaLog.Update(sistemaLog);
        }
    }
}