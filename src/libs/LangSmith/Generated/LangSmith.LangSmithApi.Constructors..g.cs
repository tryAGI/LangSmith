
#nullable enable

namespace LangSmith
{
    public sealed partial class LangSmithApi
    {
        /// <inheritdoc cref="LangSmithApi(global::System.Net.Http.HttpClient?, global::System.Uri?)"/>
        public LangSmithApi(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null) : this(httpClient, baseUri)
        {
            AuthorizeUsingApiKey(apiKey);
        }
    }
}