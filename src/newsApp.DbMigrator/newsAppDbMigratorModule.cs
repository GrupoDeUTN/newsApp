using newsApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace newsApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(newsAppEntityFrameworkCoreModule),
    typeof(newsAppApplicationContractsModule)
    )]
public class newsAppDbMigratorModule : AbpModule
{
}
