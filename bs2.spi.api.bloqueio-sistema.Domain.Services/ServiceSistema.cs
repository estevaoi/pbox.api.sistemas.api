using pbox.api.sistemas.Domain.Core.Interfaces.Repositories;
using pbox.api.sistemas.Domain.Core.Interfaces.Services;
using pbox.api.sistemas.Domain.Entities;

namespace pbox.api.sistemas.Domain.Services
{
    public class ServiceSistema : ServiceBase<Sistema>, IServiceSistema
    {
        private readonly IRepositorySistema repositorySistema;

        public ServiceSistema(IRepositorySistema repositorySistema) : base(repositorySistema)
        {
            this.repositorySistema = repositorySistema;
        }
    }
}