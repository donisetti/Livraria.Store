﻿using Volo.Abp.Modularity;

namespace Livraria.Store;

/* Inherit from this class for your domain layer tests. */
public abstract class StoreDomainTestBase<TStartupModule> : StoreTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
