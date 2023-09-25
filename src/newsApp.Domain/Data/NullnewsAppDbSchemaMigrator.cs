using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace newsApp.Data;

/* This is used if database provider does't define
 * InewsAppDbSchemaMigrator implementation.
 */
public class NullnewsAppDbSchemaMigrator : InewsAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
