using pbox.api.sistemas.Domain.Core.Interfaces.Repositories;
using pbox.api.sistemas.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace pbox.api.sistemas.Domain.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> repository;

        public ServiceBase(IRepositoryBase<T> repository)
        {
            this.repository = repository;
        }

        public void Add(T obj)
        {
            repository.Add(obj);
        }

        public IEnumerable<T> GetAll()
        {
            return repository.GetAll();
        }

        public T GetById(Guid sistemaId)
        {
            return repository.GetById(sistemaId);
        }

        public void Remove(T obj)
        {
            repository.Remove(obj);
        }

        public void Update(T obj)
        {
            repository.Update(obj);
        }
    }
}