
#nullable enable

namespace LangSmith
{
    public sealed partial class LangSmithApi
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::LangSmith.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "X-API-Key",
                Value = apiKey,
            });
        }
    }
}