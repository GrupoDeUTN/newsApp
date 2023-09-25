using System.Threading.Tasks;

namespace newsApp.Data;

public interface InewsAppDbSchemaMigrator
{
    Task MigrateAsync();
}
