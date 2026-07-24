
#nullable enable

namespace LangSmith
{
    public partial class GatewayPoliciesClient
    {

        private static readonly global::LangSmith.AutoSDKServer[] s_CreateAGatewayPolicyServers = new global::LangSmith.AutoSDKServer[]
        {            new global::LangSmith.AutoSDKServer(
                id: "https-api-smith-langchain-com",
                name: "api.smith.langchain.com",
                url: "https://api.smith.langchain.com/",
                description: ""),
            new global::LangSmith.AutoSDKServer(
                id: "file",
                name: "",
                url: "file:///",
                description: ""),
        };


        private static readonly global::LangSmith.EndPointSecurityRequirement s_CreateAGatewayPolicySecurityRequirement0 =
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
        private static readonly global::LangSmith.EndPointSecurityRequirement[] s_CreateAGatewayPolicySecurityRequirements =
            new global::LangSmith.EndPointSecurityRequirement[]
            {                s_CreateAGatewayPolicySecurityRequirement0,
            };
        partial void PrepareCreateAGatewayPolicyArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.GatewayPoliciesCreateGatewayPolicyRequest request);
        partial void PrepareCreateAGatewayPolicyRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.GatewayPoliciesCreateGatewayPolicyRequest request);
        partial void ProcessCreateAGatewayPolicyResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateAGatewayPolicyResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a gateway policy<br/>
        /// Creates a gateway policy for the calling organization.<br/>
        /// **policy_type** is one of `spend_cap`, `default_spend_cap`,<br/>
        /// `guard`, `route_config`, `rate_limit`, or `default_rate_limit`.<br/>
        /// The shape of `config` depends on policy_type:<br/>
        /// - `spend_cap` / `default_spend_cap`:<br/>
        /// `{"window": "hourly"|"daily"|"weekly"|"monthly", "limit_usd": &lt;number&gt;}`<br/>
        /// - `guard`:<br/>
        /// `{"version": 1, "detect": {"pii": &lt;bool&gt;, "secrets": &lt;bool&gt;}, "timeout_seconds": &lt;number&gt;, "timeout_action": "allow"|"block"}`<br/>
        /// `timeout_seconds` (optional, 0.1–30) caps guard pipeline execution time; defaults to 2s. `timeout_action` defaults to `allow`.<br/>
        /// - `route_config`:<br/>
        /// `{"strategy": "priority_fallback", "triggers": {"status_codes": [&lt;int&gt;]}, "fallbacks": [{"model_configs": [{"model_config_id": "&lt;playground-settings-uuid&gt;"}]}]}`<br/>
        /// `triggers` is required, with no default: `status_codes` must be a non-empty list (include 502 and 504 for upstream transport failures). `fallbacks` contains an entry whose `model_configs` are tried in priority order (1–5). `subject_matchers` must be a single `workspace_id` entry.<br/>
        /// - `rate_limit` / `default_rate_limit`:<br/>
        /// `{"version": 1, "limits": [{"metric": "requests"|"tokens", "window": "minute"|"hour", "value": &lt;integer&gt;}]}`<br/>
        /// `limits` must be non-empty; each `metric`/`window` pair may appear at most once. `value` is 1..1000000000000000.<br/>
        /// **subject_matchers** is a list of `{key, value}` pairs.<br/>
        /// `key` is one of `organization_id`, `workspace_id`, `user_id`,<br/>
        /// `api_key_id`, or `run_rule_id`. Multiple matchers AND together. A<br/>
        /// `default_spend_cap` or `default_rate_limit` uses `{key, value: ""}`<br/>
        /// so the runtime materializes a per-subject child for every distinct<br/>
        /// subject of that kind it sees in request metadata.<br/>
        /// **action** is currently always `block`. Spend caps reject the<br/>
        /// request with 402 when the limit is hit; rate limits reject with<br/>
        /// 429 (with a `Retry-After` hint) when a limit is exceeded; guard<br/>
        /// policies redact matched content in-place before forwarding upstream.<br/>
        /// **Upsert by matchers:** for `spend_cap`, `default_spend_cap`,<br/>
        /// `rate_limit`, `default_rate_limit`, and `guard`, if a policy with<br/>
        /// the same `subject_matchers` already exists in this organization,<br/>
        /// the existing policy is updated in place instead of a duplicate<br/>
        /// being created. `id` is preserved. `route_config` does not upsert<br/>
        /// by matchers — name must be unique per organization (409 on<br/>
        /// conflict). Returns 201 either way.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        /// <remarks>
        /// {<br/>
        ///   "name": "monthly-cap",<br/>
        ///   "policy_type": "spend_cap",<br/>
        ///   "action": "block",<br/>
        ///   "subject_matchers": [{"key":"organization_id","value":"&lt;org-uuid&gt;"}],<br/>
        ///   "config": {"window": "monthly", "limit_usd": 100}<br/>
        /// }
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::LangSmith.GatewayPoliciesGatewayPolicyRecord> CreateAGatewayPolicyAsync(

            global::LangSmith.GatewayPoliciesCreateGatewayPolicyRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateAGatewayPolicyAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Create a gateway policy<br/>
        /// Creates a gateway policy for the calling organization.<br/>
        /// **policy_type** is one of `spend_cap`, `default_spend_cap`,<br/>
        /// `guard`, `route_config`, `rate_limit`, or `default_rate_limit`.<br/>
        /// The shape of `config` depends on policy_type:<br/>
        /// - `spend_cap` / `default_spend_cap`:<br/>
        /// `{"window": "hourly"|"daily"|"weekly"|"monthly", "limit_usd": &lt;number&gt;}`<br/>
        /// - `guard`:<br/>
        /// `{"version": 1, "detect": {"pii": &lt;bool&gt;, "secrets": &lt;bool&gt;}, "timeout_seconds": &lt;number&gt;, "timeout_action": "allow"|"block"}`<br/>
        /// `timeout_seconds` (optional, 0.1–30) caps guard pipeline execution time; defaults to 2s. `timeout_action` defaults to `allow`.<br/>
        /// - `route_config`:<br/>
        /// `{"strategy": "priority_fallback", "triggers": {"status_codes": [&lt;int&gt;]}, "fallbacks": [{"model_configs": [{"model_config_id": "&lt;playground-settings-uuid&gt;"}]}]}`<br/>
        /// `triggers` is required, with no default: `status_codes` must be a non-empty list (include 502 and 504 for upstream transport failures). `fallbacks` contains an entry whose `model_configs` are tried in priority order (1–5). `subject_matchers` must be a single `workspace_id` entry.<br/>
        /// - `rate_limit` / `default_rate_limit`:<br/>
        /// `{"version": 1, "limits": [{"metric": "requests"|"tokens", "window": "minute"|"hour", "value": &lt;integer&gt;}]}`<br/>
        /// `limits` must be non-empty; each `metric`/`window` pair may appear at most once. `value` is 1..1000000000000000.<br/>
        /// **subject_matchers** is a list of `{key, value}` pairs.<br/>
        /// `key` is one of `organization_id`, `workspace_id`, `user_id`,<br/>
        /// `api_key_id`, or `run_rule_id`. Multiple matchers AND together. A<br/>
        /// `default_spend_cap` or `default_rate_limit` uses `{key, value: ""}`<br/>
        /// so the runtime materializes a per-subject child for every distinct<br/>
        /// subject of that kind it sees in request metadata.<br/>
        /// **action** is currently always `block`. Spend caps reject the<br/>
        /// request with 402 when the limit is hit; rate limits reject with<br/>
        /// 429 (with a `Retry-After` hint) when a limit is exceeded; guard<br/>
        /// policies redact matched content in-place before forwarding upstream.<br/>
        /// **Upsert by matchers:** for `spend_cap`, `default_spend_cap`,<br/>
        /// `rate_limit`, `default_rate_limit`, and `guard`, if a policy with<br/>
        /// the same `subject_matchers` already exists in this organization,<br/>
        /// the existing policy is updated in place instead of a duplicate<br/>
        /// being created. `id` is preserved. `route_config` does not upsert<br/>
        /// by matchers — name must be unique per organization (409 on<br/>
        /// conflict). Returns 201 either way.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        /// <remarks>
        /// {<br/>
        ///   "name": "monthly-cap",<br/>
        ///   "policy_type": "spend_cap",<br/>
        ///   "action": "block",<br/>
        ///   "subject_matchers": [{"key":"organization_id","value":"&lt;org-uuid&gt;"}],<br/>
        ///   "config": {"window": "monthly", "limit_usd": 100}<br/>
        /// }
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.GatewayPoliciesGatewayPolicyRecord>> CreateAGatewayPolicyAsResponseAsync(

            global::LangSmith.GatewayPoliciesCreateGatewayPolicyRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateAGatewayPolicyArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::LangSmith.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateAGatewayPolicySecurityRequirements,
                operationName: "CreateAGatewayPolicyAsync");

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
                                path: "/v1/platform/gateway-policies",
                                baseUri: ResolveBaseUri(
                                servers: s_CreateAGatewayPolicyServers,
                                defaultBaseUrl: "https://api.smith.langchain.com/"));
                            var __path = __pathBuilder.ToString();
                __path = global::LangSmith.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
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
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::LangSmith.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateAGatewayPolicyRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

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
                                operationId: "CreateAGatewayPolicy",
                                methodName: "CreateAGatewayPolicyAsync",
                                pathTemplate: "\"/v1/platform/gateway-policies\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
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
                        var __retryDelay = global::LangSmith.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::LangSmith.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::LangSmith.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateAGatewayPolicy",
                                methodName: "CreateAGatewayPolicyAsync",
                                pathTemplate: "\"/v1/platform/gateway-policies\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::LangSmith.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::LangSmith.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::LangSmith.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::LangSmith.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::LangSmith.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateAGatewayPolicy",
                                methodName: "CreateAGatewayPolicyAsync",
                                pathTemplate: "\"/v1/platform/gateway-policies\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::LangSmith.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
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
                ProcessCreateAGatewayPolicyResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::LangSmith.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::LangSmith.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateAGatewayPolicy",
                                methodName: "CreateAGatewayPolicyAsync",
                                pathTemplate: "\"/v1/platform/gateway-policies\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::LangSmith.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::LangSmith.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateAGatewayPolicy",
                                methodName: "CreateAGatewayPolicyAsync",
                                pathTemplate: "\"/v1/platform/gateway-policies\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // validation error
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::LangSmith.GatewayPoliciesErrorResponse? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::LangSmith.GatewayPoliciesErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::LangSmith.GatewayPoliciesErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::LangSmith.ApiException<global::LangSmith.GatewayPoliciesErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // missing or invalid auth
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::LangSmith.GatewayPoliciesErrorResponse? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::LangSmith.GatewayPoliciesErrorResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::LangSmith.GatewayPoliciesErrorResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::LangSmith.ApiException<global::LangSmith.GatewayPoliciesErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    responseBody: __content_401,
                                    responseObject: __value_401,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // LLM Gateway not enabled for the organization, or caller lacks OrganizationManage
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::LangSmith.GatewayPoliciesErrorResponse? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::LangSmith.GatewayPoliciesErrorResponse.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::LangSmith.GatewayPoliciesErrorResponse.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::LangSmith.ApiException<global::LangSmith.GatewayPoliciesErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseObject: __value_403,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // policy name conflict
                            if ((int)__response.StatusCode == 409)
                            {
                                string? __content_409 = null;
                                global::System.Exception? __exception_409 = null;
                                global::LangSmith.GatewayPoliciesErrorResponse? __value_409 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_409 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_409 = global::LangSmith.GatewayPoliciesErrorResponse.FromJson(__content_409, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_409 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_409 = global::LangSmith.GatewayPoliciesErrorResponse.FromJson(__content_409, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_409 = __ex;
                                }


                                throw global::LangSmith.ApiException<global::LangSmith.GatewayPoliciesErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_409 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_409,
                                    responseBody: __content_409,
                                    responseObject: __value_409,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Internal Server Error
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                global::LangSmith.GatewayPoliciesErrorResponse? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::LangSmith.GatewayPoliciesErrorResponse.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::LangSmith.GatewayPoliciesErrorResponse.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::LangSmith.ApiException<global::LangSmith.GatewayPoliciesErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    responseBody: __content_500,
                                    responseObject: __value_500,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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
                                ProcessCreateAGatewayPolicyResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::LangSmith.GatewayPoliciesGatewayPolicyRecord.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::LangSmith.AutoSDKHttpResponse<global::LangSmith.GatewayPoliciesGatewayPolicyRecord>(
                                        statusCode: __response.StatusCode,
                                        headers: global::LangSmith.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::LangSmith.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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

                                    var __value = await global::LangSmith.GatewayPoliciesGatewayPolicyRecord.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::LangSmith.AutoSDKHttpResponse<global::LangSmith.GatewayPoliciesGatewayPolicyRecord>(
                                        statusCode: __response.StatusCode,
                                        headers: global::LangSmith.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
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

                                    throw global::LangSmith.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Create a gateway policy<br/>
        /// Creates a gateway policy for the calling organization.<br/>
        /// **policy_type** is one of `spend_cap`, `default_spend_cap`,<br/>
        /// `guard`, `route_config`, `rate_limit`, or `default_rate_limit`.<br/>
        /// The shape of `config` depends on policy_type:<br/>
        /// - `spend_cap` / `default_spend_cap`:<br/>
        /// `{"window": "hourly"|"daily"|"weekly"|"monthly", "limit_usd": &lt;number&gt;}`<br/>
        /// - `guard`:<br/>
        /// `{"version": 1, "detect": {"pii": &lt;bool&gt;, "secrets": &lt;bool&gt;}, "timeout_seconds": &lt;number&gt;, "timeout_action": "allow"|"block"}`<br/>
        /// `timeout_seconds` (optional, 0.1–30) caps guard pipeline execution time; defaults to 2s. `timeout_action` defaults to `allow`.<br/>
        /// - `route_config`:<br/>
        /// `{"strategy": "priority_fallback", "triggers": {"status_codes": [&lt;int&gt;]}, "fallbacks": [{"model_configs": [{"model_config_id": "&lt;playground-settings-uuid&gt;"}]}]}`<br/>
        /// `triggers` is required, with no default: `status_codes` must be a non-empty list (include 502 and 504 for upstream transport failures). `fallbacks` contains an entry whose `model_configs` are tried in priority order (1–5). `subject_matchers` must be a single `workspace_id` entry.<br/>
        /// - `rate_limit` / `default_rate_limit`:<br/>
        /// `{"version": 1, "limits": [{"metric": "requests"|"tokens", "window": "minute"|"hour", "value": &lt;integer&gt;}]}`<br/>
        /// `limits` must be non-empty; each `metric`/`window` pair may appear at most once. `value` is 1..1000000000000000.<br/>
        /// **subject_matchers** is a list of `{key, value}` pairs.<br/>
        /// `key` is one of `organization_id`, `workspace_id`, `user_id`,<br/>
        /// `api_key_id`, or `run_rule_id`. Multiple matchers AND together. A<br/>
        /// `default_spend_cap` or `default_rate_limit` uses `{key, value: ""}`<br/>
        /// so the runtime materializes a per-subject child for every distinct<br/>
        /// subject of that kind it sees in request metadata.<br/>
        /// **action** is currently always `block`. Spend caps reject the<br/>
        /// request with 402 when the limit is hit; rate limits reject with<br/>
        /// 429 (with a `Retry-After` hint) when a limit is exceeded; guard<br/>
        /// policies redact matched content in-place before forwarding upstream.<br/>
        /// **Upsert by matchers:** for `spend_cap`, `default_spend_cap`,<br/>
        /// `rate_limit`, `default_rate_limit`, and `guard`, if a policy with<br/>
        /// the same `subject_matchers` already exists in this organization,<br/>
        /// the existing policy is updated in place instead of a duplicate<br/>
        /// being created. `id` is preserved. `route_config` does not upsert<br/>
        /// by matchers — name must be unique per organization (409 on<br/>
        /// conflict). Returns 201 either way.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="config"></param>
        /// <param name="description"></param>
        /// <param name="enabled"></param>
        /// <param name="name"></param>
        /// <param name="policyType"></param>
        /// <param name="priority"></param>
        /// <param name="subjectMatchers"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.GatewayPoliciesGatewayPolicyRecord> CreateAGatewayPolicyAsync(
            string? action = default,
            object? config = default,
            string? description = default,
            bool? enabled = default,
            string? name = default,
            string? policyType = default,
            int? priority = default,
            global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesSubjectMatcher>? subjectMatchers = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::LangSmith.GatewayPoliciesCreateGatewayPolicyRequest
            {
                Action = action,
                Config = config,
                Description = description,
                Enabled = enabled,
                Name = name,
                PolicyType = policyType,
                Priority = priority,
                SubjectMatchers = subjectMatchers,
            };

            return await CreateAGatewayPolicyAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}