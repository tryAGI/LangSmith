namespace LangSmith.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Ok()
    {
        using var api = GetAuthorizedApi();
        var response = await api.OkApiV1OkGetAsync();
    }
}