using pbox.api.sistemas.Domain.Core.Interfaces.Repositories;
using pbox.api.sistemas.Domain.Entities;

namespace pbox.api.sistemas.Infrastructure.Data.Repositories
{
    public class RepositorySistema : RepositoryBase<Sistema>, IRepositorySistema
    {
        private readonly SqlContext sqlContext;

        public RepositorySistema(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}