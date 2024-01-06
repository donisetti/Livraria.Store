using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Livraria.Store.Pages;

public class Index_Tests : StoreWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
