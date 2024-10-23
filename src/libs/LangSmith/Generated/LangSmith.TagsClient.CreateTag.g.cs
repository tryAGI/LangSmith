
#nullable enable

namespace LangSmith
{
    public partial class TagsClient
    {
        partial void PrepareCreateTagArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string repo,
            ref string owner,
            global::LangSmith.RepoTagRequest request);
        partial void PrepareCreateTagRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string repo,
            string owner,
            global::LangSmith.RepoTagRequest request);
        partial void ProcessCreateTagResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateTagResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Tag
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="owner"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.RepoTag> CreateTagAsync(
            string repo,
            string owner,
            global::LangSmith.RepoTagRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateTagArguments(
                httpClient: HttpClient,
                repo: ref repo,
                owner: ref owner,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/repos/{owner}/{repo}/tags",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateTagRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                repo: repo,
                owner: owner,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateTagResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessCreateTagResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::LangSmith.RepoTag.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Tag
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="owner"></param>
        /// <param name="tagName"></param>
        /// <param name="commitId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.RepoTag> CreateTagAsync(
            string repo,
            string owner,
            string tagName,
            global::System.Guid commitId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::LangSmith.RepoTagRequest
            {
                TagName = tagName,
                CommitId = commitId,
            };

            return await CreateTagAsync(
                repo: repo,
                owner: owner,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}