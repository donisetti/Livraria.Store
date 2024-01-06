using System;
using System.Collections.Generic;
using System.Text;
using Livraria.Store.Localization;
using Volo.Abp.Application.Services;

namespace Livraria.Store;

/* Inherit your application services from this class.
 */
public abstract class StoreAppService : ApplicationService
{
    protected StoreAppService()
    {
        LocalizationResource = typeof(StoreResource);
    }
}
