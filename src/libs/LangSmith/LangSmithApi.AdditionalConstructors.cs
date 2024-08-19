using System.Net.Http;

namespace LangSmith;

public partial class LangSmithApi
{
    /// <inheritdoc cref="LangSmithApi(HttpClient?, Uri?)"/>
    public LangSmithApi(
        string apiKey, 
        HttpClient? httpClient = null,
        Uri? baseUri = null) : this(httpClient, baseUri)
    {
        AuthorizeUsingApiKey(apiKey);
    }
}