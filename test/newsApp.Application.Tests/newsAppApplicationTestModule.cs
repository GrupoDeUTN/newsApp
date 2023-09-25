using Volo.Abp.Modularity;

namespace newsApp;

[DependsOn(
    typeof(newsAppApplicationModule),
    typeof(newsAppDomainTestModule)
    )]
public class newsAppApplicationTestModule : AbpModule
{

}
