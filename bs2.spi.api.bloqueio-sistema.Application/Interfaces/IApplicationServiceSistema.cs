using pbox.api.sistemas.Application.Dto;
using System;
using System.Collections.Generic;

namespace pbox.api.sistemas.Application.Interfaces
{
    public interface IApplicationServiceSistema
    {
        void Add(SistemaDto sistemaDto);

        void Update(SistemaDto sistemaDto);

        void Remove(SistemaDto sistemaDto);

        IEnumerable<SistemaDto> GetAll();

        SistemaDto GetById(Guid sistemaId);
    }
}