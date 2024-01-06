using Xunit;

namespace Livraria.Store.EntityFrameworkCore;

[CollectionDefinition(StoreTestConsts.CollectionDefinitionName)]
public class StoreEntityFrameworkCoreCollection : ICollectionFixture<StoreEntityFrameworkCoreFixture>
{

}
