using Livraria.Store.Samples;
using Xunit;

namespace Livraria.Store.EntityFrameworkCore.Domains;

[Collection(StoreTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<StoreEntityFrameworkCoreTestModule>
{

}
