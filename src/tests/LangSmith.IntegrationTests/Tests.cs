using tryAGI.OpenAI;

namespace LangSmith.IntegrationTests;

[TestClass]
public partial class Tests
{
    static Tests()
    {
        LoadEnvironmentFile();
    }

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

    private static void LoadEnvironmentFile()
    {
        var repositoryRoot = FindRepositoryRoot();
        if (repositoryRoot is null)
        {
            return;
        }

        var path = Path.Combine(repositoryRoot, ".env");
        if (!File.Exists(path))
        {
            return;
        }

        foreach (var rawLine in File.ReadLines(path))
        {
            var line = rawLine.Trim();
            if (line.Length == 0 || line.StartsWith('#'))
            {
                continue;
            }

            var separatorIndex = line.IndexOf('=');
            if (separatorIndex <= 0)
            {
                continue;
            }

            var key = line[..separatorIndex].Trim();
            if (key.Length == 0 || !string.IsNullOrEmpty(Environment.GetEnvironmentVariable(key)))
            {
                continue;
            }

            var value = line[(separatorIndex + 1)..].Trim();
            if (value.Length >= 2 &&
                ((value[0] == '"' && value[^1] == '"') ||
                 (value[0] == '\'' && value[^1] == '\'')))
            {
                value = value[1..^1];
            }

            Environment.SetEnvironmentVariable(key, value);
        }
    }

    private static string? FindRepositoryRoot()
    {
        for (var directory = new DirectoryInfo(AppContext.BaseDirectory); directory is not null; directory = directory.Parent)
        {
            if (File.Exists(Path.Combine(directory.FullName, ".gitignore")) &&
                Directory.Exists(Path.Combine(directory.FullName, "src")))
            {
                return directory.FullName;
            }
        }

        return null;
    }
}
