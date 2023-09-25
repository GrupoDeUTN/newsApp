using newsApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace newsApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class newsAppController : AbpControllerBase
{
    protected newsAppController()
    {
        LocalizationResource = typeof(newsAppResource);
    }
}
