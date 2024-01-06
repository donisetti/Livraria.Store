using Livraria.Store.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Livraria.Store.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class StorePageModel : AbpPageModel
{
    protected StorePageModel()
    {
        LocalizationResourceType = typeof(StoreResource);
    }
}
