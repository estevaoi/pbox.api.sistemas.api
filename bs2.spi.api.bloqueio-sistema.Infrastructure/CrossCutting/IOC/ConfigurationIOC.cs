using Autofac;
using pbox.api.sistemas.Application;
using pbox.api.sistemas.Application.Interfaces;
using pbox.api.sistemas.Application.Interfaces.Mappers;
using pbox.api.sistemas.Application.Mappers;
using pbox.api.sistemas.Domain.Core.Interfaces.Repositories;
using pbox.api.sistemas.Domain.Core.Interfaces.Services;
using pbox.api.sistemas.Domain.Services;
using pbox.api.sistemas.Infrastructure.Data.Repositories;

namespace pbox.api.sistemas.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceSistema>().As<IApplicationServiceSistema>();
            builder.RegisterType<ApplicationServiceSistemaLog>().As<IApplicationServiceSistemaLog>();

            builder.RegisterType<ServiceSistema>().As<IServiceSistema>();
            builder.RegisterType<ServiceSistemaLog>().As<IServiceSistemaLog>();

            builder.RegisterType<RepositorySistema>().As<IRepositorySistema>();
            builder.RegisterType<RepositorySistemaLog>().As<IRepositorySistemaLog>();

            builder.RegisterType<MapperSistema>().As<IMapperSistema>();
            builder.RegisterType<MapperSistemaLog>().As<IMapperSistemaLog>();

            #endregion IOC
        }
    }
}