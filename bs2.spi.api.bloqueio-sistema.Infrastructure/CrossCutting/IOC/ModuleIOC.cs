using Autofac;

namespace pbox.api.sistemas.Infrastructure.CrossCutting.IOC
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder build)
        {
            ConfigurationIOC.Load(build);
        }
    }
}