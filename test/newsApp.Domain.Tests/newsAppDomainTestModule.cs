using newsApp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace newsApp;

[DependsOn(
    typeof(newsAppEntityFrameworkCoreTestModule)
    )]
public class newsAppDomainTestModule : AbpModule
{

}
