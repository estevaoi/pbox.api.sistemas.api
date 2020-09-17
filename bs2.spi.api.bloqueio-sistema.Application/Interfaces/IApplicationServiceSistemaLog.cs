using pbox.api.sistemas.Application.Dto;
using System;
using System.Collections.Generic;

namespace pbox.api.sistemas.Application.Interfaces
{
    public interface IApplicationServiceSistemaLog
    {
        void Add(SistemaLogDto sistemaLogDto);

        IEnumerable<SistemaLogDto> GetAll();

        SistemaLogDto GetById(Guid sistemaId);

        void Remove(SistemaLogDto sistemaLogDto);

        void Update(SistemaLogDto sistemaLogDto);
    }
}