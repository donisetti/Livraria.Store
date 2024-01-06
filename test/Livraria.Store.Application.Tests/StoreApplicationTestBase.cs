using Volo.Abp.Modularity;

namespace Livraria.Store;

public abstract class StoreApplicationTestBase<TStartupModule> : StoreTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
