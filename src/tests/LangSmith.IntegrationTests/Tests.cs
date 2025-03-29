using tryAGI.OpenAI;

namespace LangSmith.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static LangSmithClient GetAuthorizedClient()
    {
        return new LangSmithClient(
            Environment.GetEnvironmentVariable("LANGSMITH_API_KEY") ??
            throw new AssertInconclusiveException("LANGSMITH_API_KEY is required"));
    }
    
    private static OpenAiClient GetAuthorizedOpenAiClient()
    {
        return new OpenAiClient(
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") ??
            throw new AssertInconclusiveException("OPENAI_API_KEY is required"));
    }
}