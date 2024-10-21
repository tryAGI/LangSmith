
#nullable enable

namespace LangSmith
{
    public partial class TagsClient
    {
        partial void PrepareDeleteTagArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string repo,
            ref string tagName);
        partial void PrepareDeleteTagRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string repo,
            string tagName);
        partial void ProcessDeleteTagResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeleteTagResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete Tag
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="tagName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> DeleteTagAsync(
            string repo,
            string tagName,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDeleteTagArguments(
                httpClient: _httpClient,
                repo: ref repo,
                tagName: ref tagName);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/repos/{owner}/{repo}/tags/{tagName}",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeleteTagRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                repo: repo,
                tagName: tagName);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDeleteTagResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDeleteTagResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return __content;
        }
    }
}