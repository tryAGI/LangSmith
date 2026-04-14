
#nullable enable

namespace LangSmith
{
    public partial class OrgsClient
    {


        private static readonly global::LangSmith.EndPointSecurityRequirement s_ListOrgMembersWithWorkspaceRolesSecurityRequirement0 =
            new global::LangSmith.EndPointSecurityRequirement
            {
                Authorizations = new global::LangSmith.EndPointAuthorizationRequirement[]
                {                    new global::LangSmith.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApikeyXApiKey",
                        Location = "Header",
                        Name = "X-API-Key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::LangSmith.EndPointSecurityRequirement[] s_ListOrgMembersWithWorkspaceRolesSecurityRequirements =
            new global::LangSmith.EndPointSecurityRequirement[]
            {                s_ListOrgMembersWithWorkspaceRolesSecurityRequirement0,
            };
        partial void PrepareListOrgMembersWithWorkspaceRolesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? limit,
            ref int? offset,
            ref bool? activeIs,
            ref bool? pendingIs,
            byte[]? nameLike,
            byte[]? emailLike,
            byte[]? workspaceNameLike,
            byte[]? organizationRoleLike,
            byte[]? workspaceRoleLike);
        partial void PrepareListOrgMembersWithWorkspaceRolesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? limit,
            int? offset,
            bool? activeIs,
            bool? pendingIs,
            byte[]? nameLike,
            byte[]? emailLike,
            byte[]? workspaceNameLike,
            byte[]? organizationRoleLike,
            byte[]? workspaceRoleLike);
        partial void ProcessListOrgMembersWithWorkspaceRolesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListOrgMembersWithWorkspaceRolesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List org members with workspace roles<br/>
        /// Returns a paginated list of org members (active and pending) enriched with workspace memberships.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="activeIs"></param>
        /// <param name="pendingIs"></param>
        /// <param name="nameLike"></param>
        /// <param name="emailLike"></param>
        /// <param name="workspaceNameLike"></param>
        /// <param name="organizationRoleLike"></param>
        /// <param name="workspaceRoleLike"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.OrgsOrgMemberEnriched>> ListOrgMembersWithWorkspaceRolesAsync(
            int? limit = default,
            int? offset = default,
            bool? activeIs = default,
            bool? pendingIs = default,
            byte[]? nameLike = default,
            byte[]? emailLike = default,
            byte[]? workspaceNameLike = default,
            byte[]? organizationRoleLike = default,
            byte[]? workspaceRoleLike = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ListOrgMembersWithWorkspaceRolesAsResponseAsync(
                limit: limit,
                offset: offset,
                activeIs: activeIs,
                pendingIs: pendingIs,
                nameLike: nameLike,
                emailLike: emailLike,
                workspaceNameLike: workspaceNameLike,
                organizationRoleLike: organizationRoleLike,
                workspaceRoleLike: workspaceRoleLike,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// List org members with workspace roles<br/>
        /// Returns a paginated list of org members (active and pending) enriched with workspace memberships.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="activeIs"></param>
        /// <param name="pendingIs"></param>
        /// <param name="nameLike"></param>
        /// <param name="emailLike"></param>
        /// <param name="workspaceNameLike"></param>
        /// <param name="organizationRoleLike"></param>
        /// <param name="workspaceRoleLike"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LangSmith.OrgsOrgMemberEnriched>>> ListOrgMembersWithWorkspaceRolesAsResponseAsync(
            int? limit = default,
            int? offset = default,
            bool? activeIs = default,
            bool? pendingIs = default,
            byte[]? nameLike = default,
            byte[]? emailLike = default,
            byte[]? workspaceNameLike = default,
            byte[]? organizationRoleLike = default,
            byte[]? workspaceRoleLike = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListOrgMembersWithWorkspaceRolesArguments(
                httpClient: HttpClient,
                limit: ref limit,
                offset: ref offset,
                activeIs: ref activeIs,
                pendingIs: ref pendingIs,
                nameLike: nameLike,
                emailLike: emailLike,
                workspaceNameLike: workspaceNameLike,
                organizationRoleLike: organizationRoleLike,
                workspaceRoleLike: workspaceRoleLike);


            var __authorizations = global::LangSmith.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListOrgMembersWithWorkspaceRolesSecurityRequirements,
                operationName: "ListOrgMembersWithWorkspaceRolesAsync");

            using var __timeoutCancellationTokenSource = global::LangSmith.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::LangSmith.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::LangSmith.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::LangSmith.PathBuilder(
                                path: "/v1/platform/orgs/current/members",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("offset", offset?.ToString())
                                .AddOptionalParameter("active_is", activeIs?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("pending_is", pendingIs?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("name_like", nameLike?.ToString())
                                .AddOptionalParameter("email_like", emailLike?.ToString())
                                .AddOptionalParameter("workspace_name_like", workspaceNameLike?.ToString())
                                .AddOptionalParameter("organization_role_like", organizationRoleLike?.ToString())
                                .AddOptionalParameter("workspace_role_like", workspaceRoleLike?.ToString()) 
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::LangSmith.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                global::LangSmith.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareListOrgMembersWithWorkspaceRolesRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    limit: limit,
                    offset: offset,
                    activeIs: activeIs,
                    pendingIs: pendingIs,
                    nameLike: nameLike,
                    emailLike: emailLike,
                    workspaceNameLike: workspaceNameLike,
                    organizationRoleLike: organizationRoleLike,
                    workspaceRoleLike: workspaceRoleLike);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::LangSmith.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::LangSmith.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListOrgMembersWithWorkspaceRoles",
                                methodName: "ListOrgMembersWithWorkspaceRolesAsync",
                                pathTemplate: "\"/v1/platform/orgs/current/members\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::LangSmith.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::LangSmith.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListOrgMembersWithWorkspaceRoles",
                                methodName: "ListOrgMembersWithWorkspaceRolesAsync",
                                pathTemplate: "\"/v1/platform/orgs/current/members\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::LangSmith.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::LangSmith.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::LangSmith.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::LangSmith.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListOrgMembersWithWorkspaceRoles",
                                methodName: "ListOrgMembersWithWorkspaceRolesAsync",
                                pathTemplate: "\"/v1/platform/orgs/current/members\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::LangSmith.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessListOrgMembersWithWorkspaceRolesResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::LangSmith.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::LangSmith.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListOrgMembersWithWorkspaceRoles",
                                methodName: "ListOrgMembersWithWorkspaceRolesAsync",
                                pathTemplate: "\"/v1/platform/orgs/current/members\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::LangSmith.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::LangSmith.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListOrgMembersWithWorkspaceRoles",
                                methodName: "ListOrgMembersWithWorkspaceRolesAsync",
                                pathTemplate: "\"/v1/platform/orgs/current/members\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Bad request
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::System.Collections.Generic.Dictionary<string, string>? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = (global::System.Collections.Generic.Dictionary<string, string>?)global::System.Text.Json.JsonSerializer.Deserialize(__content_400, typeof(global::System.Collections.Generic.Dictionary<string, string>), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = (global::System.Collections.Generic.Dictionary<string, string>?)global::System.Text.Json.JsonSerializer.Deserialize(__content_400, typeof(global::System.Collections.Generic.Dictionary<string, string>), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }

                                throw new global::LangSmith.ApiException<global::System.Collections.Generic.Dictionary<string, string>>(
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_400,
                                    ResponseObject = __value_400,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // Unauthorized
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::System.Collections.Generic.Dictionary<string, string>? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = (global::System.Collections.Generic.Dictionary<string, string>?)global::System.Text.Json.JsonSerializer.Deserialize(__content_401, typeof(global::System.Collections.Generic.Dictionary<string, string>), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = (global::System.Collections.Generic.Dictionary<string, string>?)global::System.Text.Json.JsonSerializer.Deserialize(__content_401, typeof(global::System.Collections.Generic.Dictionary<string, string>), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }

                                throw new global::LangSmith.ApiException<global::System.Collections.Generic.Dictionary<string, string>>(
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_401,
                                    ResponseObject = __value_401,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // Internal server error
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                global::System.Collections.Generic.Dictionary<string, string>? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = (global::System.Collections.Generic.Dictionary<string, string>?)global::System.Text.Json.JsonSerializer.Deserialize(__content_500, typeof(global::System.Collections.Generic.Dictionary<string, string>), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = (global::System.Collections.Generic.Dictionary<string, string>?)global::System.Text.Json.JsonSerializer.Deserialize(__content_500, typeof(global::System.Collections.Generic.Dictionary<string, string>), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }

                                throw new global::LangSmith.ApiException<global::System.Collections.Generic.Dictionary<string, string>>(
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_500,
                                    ResponseObject = __value_500,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessListOrgMembersWithWorkspaceRolesResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = (global::System.Collections.Generic.IList<global::LangSmith.OrgsOrgMemberEnriched>?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::LangSmith.OrgsOrgMemberEnriched>), JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::LangSmith.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LangSmith.OrgsOrgMemberEnriched>>(
                                        statusCode: __response.StatusCode,
                                        headers: global::LangSmith.AutoSDKHttpResponse.CreateHeaders(__response),
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::LangSmith.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = (global::System.Collections.Generic.IList<global::LangSmith.OrgsOrgMemberEnriched>?)await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.IList<global::LangSmith.OrgsOrgMemberEnriched>), JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::LangSmith.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LangSmith.OrgsOrgMemberEnriched>>(
                                        statusCode: __response.StatusCode,
                                        headers: global::LangSmith.AutoSDKHttpResponse.CreateHeaders(__response),
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw new global::LangSmith.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}