using pbox.api.sistemas.Domain.Core.Interfaces.Repositories;
using pbox.api.sistemas.Domain.Core.Interfaces.Services;
using pbox.api.sistemas.Domain.Entities;

namespace pbox.api.sistemas.Domain.Services
{
    public class ServiceSistemaLog : ServiceBase<SistemaLog>, IServiceSistemaLog
    {
        private readonly IRepositorySistemaLog repositorySistemaLog;

        public ServiceSistemaLog(IRepositorySistemaLog repositorySistemaLog) : base(repositorySistemaLog)
        {
            this.repositorySistemaLog = repositorySistemaLog;
        }
    }
}