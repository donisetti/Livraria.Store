using Volo.Abp.Modularity;

namespace Livraria.Store;

[DependsOn(
    typeof(StoreDomainModule),
    typeof(StoreTestBaseModule)
)]
public class StoreDomainTestModule : AbpModule
{

}
