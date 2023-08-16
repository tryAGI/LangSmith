namespace LangSmith.IntegrationTests;

[TestClass]
public class GeneralTests
{
    [TestMethod]
    public void Generate()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("LANGSMITH_API_KEY") ??
            throw new AssertInconclusiveException("LANGSMITH_API_KEY environment variable is not found.");

        using var client = new HttpClient();
    }
}
