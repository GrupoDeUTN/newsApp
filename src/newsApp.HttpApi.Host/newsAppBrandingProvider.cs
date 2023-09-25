using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace newsApp;

[Dependency(ReplaceServices = true)]
public class newsAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "newsApp";
}
