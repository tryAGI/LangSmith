
#nullable enable

namespace LangSmith
{
    public partial interface IIssuesAgentClient
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingApiKeyInHeader(
            string apiKey);
    }
}