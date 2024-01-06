using Microsoft.AspNetCore.Builder;
using Livraria.Store;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<StoreWebTestModule>();

public partial class Program
{
}
