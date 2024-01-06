using Livraria.Store.Samples;
using Xunit;

namespace Livraria.Store.EntityFrameworkCore.Applications;

[Collection(StoreTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<StoreEntityFrameworkCoreTestModule>
{

}
