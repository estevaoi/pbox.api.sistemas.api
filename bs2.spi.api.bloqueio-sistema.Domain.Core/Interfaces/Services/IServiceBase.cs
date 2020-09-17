using System;
using System.Collections.Generic;

namespace pbox.api.sistemas.Domain.Core.Interfaces.Services
{
    public interface IServiceBase<T> where T : class
    {
        void Add(T obj);

        void Update(T obj);

        void Remove(T obj);

        IEnumerable<T> GetAll();

        T GetById(Guid sistemaId);
    }
}