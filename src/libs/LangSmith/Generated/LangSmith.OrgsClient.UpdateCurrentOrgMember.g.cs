
#nullable enable

namespace LangSmith
{
    public partial class OrgsClient
    {
        partial void PrepareUpdateCurrentOrgMemberArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid identityId,
            global::LangSmith.OrgIdentityPatch request);
        partial void PrepareUpdateCurrentOrgMemberRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid identityId,
            global::LangSmith.OrgIdentityPatch request);
        partial void ProcessUpdateCurrentOrgMemberResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateCurrentOrgMemberResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Current Org Member<br/>
        /// This is used for updating a user's role (all auth modes) or full_name/password (basic auth)
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> UpdateCurrentOrgMemberAsync(
            global::System.Guid identityId,
            global::LangSmith.OrgIdentityPatch request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateCurrentOrgMemberArguments(
                httpClient: HttpClient,
                identityId: ref identityId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/orgs/current/members/{identityId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
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
            PrepareUpdateCurrentOrgMemberRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                identityId: identityId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateCurrentOrgMemberResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessUpdateCurrentOrgMemberResponseContent(
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

            return __content;
        }

        /// <summary>
        /// Update Current Org Member<br/>
        /// This is used for updating a user's role (all auth modes) or full_name/password (basic auth)
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="password"></param>
        /// <param name="fullName"></param>
        /// <param name="roleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> UpdateCurrentOrgMemberAsync(
            global::System.Guid identityId,
            string? password = default,
            string? fullName = default,
            global::System.Guid? roleId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::LangSmith.OrgIdentityPatch
            {
                Password = password,
                FullName = fullName,
                RoleId = roleId,
            };

            return await UpdateCurrentOrgMemberAsync(
                identityId: identityId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}