
#nullable enable

namespace LangSmith
{
    public partial class CommitsClient
    {
        partial void PrepareGetCommitApiV1CommitsOwnerRepoCommitGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string commit,
            ref bool getExamples,
            ref bool isView,
            ref global::System.AnyOf<bool?, object>? includeModel);
        partial void PrepareGetCommitApiV1CommitsOwnerRepoCommitGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string commit,
            bool getExamples,
            bool isView,
            global::System.AnyOf<bool?, object>? includeModel);
        partial void ProcessGetCommitApiV1CommitsOwnerRepoCommitGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetCommitApiV1CommitsOwnerRepoCommitGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Commit<br/>
        /// Download a repo.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="commit"></param>
        /// <param name="getExamples">
        /// Default Value: false
        /// </param>
        /// <param name="isView">
        /// Default Value: false
        /// </param>
        /// <param name="includeModel">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.CommitManifestResponse> GetCommitApiV1CommitsOwnerRepoCommitGetAsync(
            string owner,
            string repo,
            string commit,
            bool getExamples = false,
            bool isView = false,
            global::System.AnyOf<bool?, object>? includeModel = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetCommitApiV1CommitsOwnerRepoCommitGetArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                commit: ref commit,
                getExamples: ref getExamples,
                isView: ref isView,
                includeModel: ref includeModel);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/commits/{owner}/{repo}/{commit}?get_examples={getExamples}&is_view={isView}&include_model={includeModel}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetCommitApiV1CommitsOwnerRepoCommitGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                commit: commit,
                getExamples: getExamples,
                isView: isView,
                includeModel: includeModel);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetCommitApiV1CommitsOwnerRepoCommitGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetCommitApiV1CommitsOwnerRepoCommitGetResponseContent(
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

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.CommitManifestResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}