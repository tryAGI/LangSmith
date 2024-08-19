
#nullable enable

namespace LangSmith
{
    public partial class OrgsClient
    {
        partial void PrepareUpdateCurrentUserApiV1OrgsMembersBasicPatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.BasicAuthUserPatch request);
        partial void PrepareUpdateCurrentUserApiV1OrgsMembersBasicPatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.BasicAuthUserPatch request);
        partial void ProcessUpdateCurrentUserApiV1OrgsMembersBasicPatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateCurrentUserApiV1OrgsMembersBasicPatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Current User<br/>
        /// Update a user's full_name/password (basic auth only)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.UpdateCurrentUserApiV1OrgsMembersBasicPatchResponse> UpdateCurrentUserApiV1OrgsMembersBasicPatchAsync(
            global::LangSmith.BasicAuthUserPatch request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateCurrentUserApiV1OrgsMembersBasicPatchArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/orgs/members/basic", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.BasicAuthUserPatch);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateCurrentUserApiV1OrgsMembersBasicPatchRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateCurrentUserApiV1OrgsMembersBasicPatchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateCurrentUserApiV1OrgsMembersBasicPatchResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.UpdateCurrentUserApiV1OrgsMembersBasicPatchResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Current User<br/>
        /// Update a user's full_name/password (basic auth only)
        /// </summary>
        /// <param name="password"></param>
        /// <param name="fullName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.UpdateCurrentUserApiV1OrgsMembersBasicPatchResponse> UpdateCurrentUserApiV1OrgsMembersBasicPatchAsync(
            global::System.AnyOf<string?, object>? password = default,
            global::System.AnyOf<string?, object>? fullName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.BasicAuthUserPatch
            {
                Password = password,
                FullName = fullName,
            };

            return await UpdateCurrentUserApiV1OrgsMembersBasicPatchAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}