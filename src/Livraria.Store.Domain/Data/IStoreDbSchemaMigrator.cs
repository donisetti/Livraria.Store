using System.Threading.Tasks;

namespace Livraria.Store.Data;

public interface IStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
