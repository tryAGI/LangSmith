namespace LangSmith.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Ok()
    {
        using var client = GetAuthorizedClient();
        var response = await client.OkAsync();
    }
}