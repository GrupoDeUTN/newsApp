using System;
using System.Collections.Generic;
using System.Text;
using newsApp.Localization;
using Volo.Abp.Application.Services;

namespace newsApp;

/* Inherit your application services from this class.
 */
public abstract class newsAppAppService : ApplicationService
{
    protected newsAppAppService()
    {
        LocalizationResource = typeof(newsAppResource);
    }
}
