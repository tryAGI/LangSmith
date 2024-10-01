
#nullable enable

namespace LangSmith
{
    public sealed partial class LangSmithApi
    {
        /// <inheritdoc cref="LangSmithApi(global::System.Net.Http.HttpClient?, global::System.Uri?, global::LangSmith.EndPointAuthorization?)"/>
        public LangSmithApi(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::LangSmith.EndPointAuthorization? authorization = null) : this(httpClient, baseUri, authorization)
        {
            Authorizing(_httpClient, ref apiKey);

            AuthorizeUsingApiKeyInHeader(apiKey);

            Authorized(_httpClient);
        }

        partial void Authorizing(
            global::System.Net.Http.HttpClient client,
            ref string apiKey);
        partial void Authorized(
            global::System.Net.Http.HttpClient client);
    }
}