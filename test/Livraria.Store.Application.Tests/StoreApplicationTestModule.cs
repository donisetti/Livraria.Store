using Volo.Abp.Modularity;

namespace Livraria.Store;

[DependsOn(
    typeof(StoreApplicationModule),
    typeof(StoreDomainTestModule)
)]
public class StoreApplicationTestModule : AbpModule
{

}
