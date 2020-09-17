using pbox.api.sistemas.Domain.Core.Interfaces.Repositories;
using pbox.api.sistemas.Domain.Entities;

namespace pbox.api.sistemas.Infrastructure.Data.Repositories
{
    public class RepositorySistemaLog : RepositoryBase<SistemaLog>, IRepositorySistemaLog
    {
        private readonly SqlContext sqlContext;

        public RepositorySistemaLog(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}