using OpenAI;

namespace LangSmith.IntegrationTests;

[TestClass]
public partial class Tests
{
    public static LangSmithApi GetAuthorizedApi()
    {
        return new LangSmithApi(
            Environment.GetEnvironmentVariable("LANGSMITH_API_KEY") ??
            throw new AssertInconclusiveException("LANGSMITH_API_KEY is required"));
    }
    
    public static OpenAiApi GetAuthorizedOpenAiApi()
    {
        return new OpenAiApi(
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") ??
            throw new AssertInconclusiveException("OPENAI_API_KEY is required"));
    }
}