
#nullable enable

namespace LangSmith
{
    public partial class RunsClient
    {

        private static readonly global::LangSmith.AutoSDKServer[] s_IngestRunsMultipartServers = new global::LangSmith.AutoSDKServer[]
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


        private static readonly global::LangSmith.EndPointSecurityRequirement s_IngestRunsMultipartSecurityRequirement0 =
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
        private static readonly global::LangSmith.EndPointSecurityRequirement[] s_IngestRunsMultipartSecurityRequirements =
            new global::LangSmith.EndPointSecurityRequirement[]
            {                s_IngestRunsMultipartSecurityRequirement0,
            };
        partial void PrepareIngestRunsMultipartArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.CreateRunsMultipartRequest request);
        partial void PrepareIngestRunsMultipartRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.CreateRunsMultipartRequest request);
        partial void ProcessIngestRunsMultipartResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessIngestRunsMultipartResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Ingest Runs (Multipart)<br/>
        /// Ingests multiple runs, feedback objects, and binary attachments in a single `multipart/form-data` request.<br/>
        /// **Part‑name pattern**: `&lt;event&gt;.&lt;run_id&gt;[.&lt;field&gt;]` where `event` ∈ {`post`, `patch`, `feedback`, `attachment`}.<br/>
        /// * `post|patch.&lt;run_id&gt;` – JSON run payload.<br/>
        /// * `post|patch.&lt;run_id&gt;.&lt;field&gt;` – out‑of‑band run data (`inputs`, `outputs`, `events`, `error`, `extra`, `serialized`).<br/>
        /// * `feedback.&lt;run_id&gt;` – JSON feedback payload (must include `trace_id`).<br/>
        /// * `attachment.&lt;run_id&gt;.&lt;filename&gt;` – arbitrary binary attachment stored in S3.<br/>
        /// **Headers**: every part must set `Content-Type` **and** either a `Content-Length` header or `length` parameter. Per‑part `Content-Encoding` is **not** allowed; the top‑level request may be `Content-Encoding: gzip` or `Content-Encoding: zstd`.<br/>
        /// **Best performance** for high‑volume ingestion.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> IngestRunsMultipartAsync(

            global::LangSmith.CreateRunsMultipartRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareIngestRunsMultipartArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::LangSmith.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_IngestRunsMultipartSecurityRequirements,
                operationName: "IngestRunsMultipartAsync");

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
                                path: "/runs/multipart",
                                baseUri: ResolveBaseUri(
                                servers: s_IngestRunsMultipartServers,
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
                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            if (request.Post_runId_ != default)
                            {

                                var __contentPost_runId_ = new global::System.Net.Http.ByteArrayContent(request.Post_runId_ ?? global::System.Array.Empty<byte>());
                                __httpRequestContent.Add(
                                    content: __contentPost_runId_,
                                    name: "\"post.{run_id}\"",
                                    fileName: request.Post_runId_name != null ? $"\"{request.Post_runId_name}\"" : string.Empty);
                                if (__contentPost_runId_.Headers.ContentDisposition != null)
                                {
                                    __contentPost_runId_.Headers.ContentDisposition.FileNameStar = null;
                                }
                            } 
                            if (request.Patch_runId_ != default)
                            {

                                var __contentPatch_runId_ = new global::System.Net.Http.ByteArrayContent(request.Patch_runId_ ?? global::System.Array.Empty<byte>());
                                __httpRequestContent.Add(
                                    content: __contentPatch_runId_,
                                    name: "\"patch.{run_id}\"",
                                    fileName: request.Patch_runId_name != null ? $"\"{request.Patch_runId_name}\"" : string.Empty);
                                if (__contentPatch_runId_.Headers.ContentDisposition != null)
                                {
                                    __contentPatch_runId_.Headers.ContentDisposition.FileNameStar = null;
                                }
                            } 
                            if (request.Post_runId_Inputs != default)
                            {

                                var __contentPost_runId_Inputs = new global::System.Net.Http.ByteArrayContent(request.Post_runId_Inputs ?? global::System.Array.Empty<byte>());
                                __httpRequestContent.Add(
                                    content: __contentPost_runId_Inputs,
                                    name: "\"post.{run_id}.inputs\"",
                                    fileName: request.Post_runId_Inputsname != null ? $"\"{request.Post_runId_Inputsname}\"" : string.Empty);
                                if (__contentPost_runId_Inputs.Headers.ContentDisposition != null)
                                {
                                    __contentPost_runId_Inputs.Headers.ContentDisposition.FileNameStar = null;
                                }
                            } 
                            if (request.Patch_runId_Outputs != default)
                            {

                                var __contentPatch_runId_Outputs = new global::System.Net.Http.ByteArrayContent(request.Patch_runId_Outputs ?? global::System.Array.Empty<byte>());
                                __httpRequestContent.Add(
                                    content: __contentPatch_runId_Outputs,
                                    name: "\"patch.{run_id}.outputs\"",
                                    fileName: request.Patch_runId_Outputsname != null ? $"\"{request.Patch_runId_Outputsname}\"" : string.Empty);
                                if (__contentPatch_runId_Outputs.Headers.ContentDisposition != null)
                                {
                                    __contentPatch_runId_Outputs.Headers.ContentDisposition.FileNameStar = null;
                                }
                            } 
                            if (request.Feedback_runId_ != default)
                            {

                                var __contentFeedback_runId_ = new global::System.Net.Http.ByteArrayContent(request.Feedback_runId_ ?? global::System.Array.Empty<byte>());
                                __httpRequestContent.Add(
                                    content: __contentFeedback_runId_,
                                    name: "\"feedback.{run_id}\"",
                                    fileName: request.Feedback_runId_name != null ? $"\"{request.Feedback_runId_name}\"" : string.Empty);
                                if (__contentFeedback_runId_.Headers.ContentDisposition != null)
                                {
                                    __contentFeedback_runId_.Headers.ContentDisposition.FileNameStar = null;
                                }
                            } 
                            if (request.Attachment_runId__filename_ != default)
                            {

                                var __contentAttachment_runId__filename_ = new global::System.Net.Http.ByteArrayContent(request.Attachment_runId__filename_ ?? global::System.Array.Empty<byte>());
                                __httpRequestContent.Add(
                                    content: __contentAttachment_runId__filename_,
                                    name: "\"attachment.{run_id}.{filename}\"",
                                    fileName: request.Attachment_runId__filename_name != null ? $"\"{request.Attachment_runId__filename_name}\"" : string.Empty);
                                if (__contentAttachment_runId__filename_.Headers.ContentDisposition != null)
                                {
                                    __contentAttachment_runId__filename_.Headers.ContentDisposition.FileNameStar = null;
                                }
                            }
                            __httpRequest.Content = __httpRequestContent;
                global::LangSmith.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareIngestRunsMultipartRequest(
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
                                operationId: "IngestRunsMultipart",
                                methodName: "IngestRunsMultipartAsync",
                                pathTemplate: "\"/runs/multipart\"",
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
                                operationId: "IngestRunsMultipart",
                                methodName: "IngestRunsMultipartAsync",
                                pathTemplate: "\"/runs/multipart\"",
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
                                operationId: "IngestRunsMultipart",
                                methodName: "IngestRunsMultipartAsync",
                                pathTemplate: "\"/runs/multipart\"",
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
                ProcessIngestRunsMultipartResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::LangSmith.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::LangSmith.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "IngestRunsMultipart",
                                methodName: "IngestRunsMultipartAsync",
                                pathTemplate: "\"/runs/multipart\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::LangSmith.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::LangSmith.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "IngestRunsMultipart",
                                methodName: "IngestRunsMultipartAsync",
                                pathTemplate: "\"/runs/multipart\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Bad Request
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::LangSmith.RunsErrorResponse? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::LangSmith.RunsErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::LangSmith.RunsErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }

                                throw new global::LangSmith.ApiException<global::LangSmith.RunsErrorResponse>(
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
                            // Forbidden
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::LangSmith.RunsErrorResponse? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::LangSmith.RunsErrorResponse.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::LangSmith.RunsErrorResponse.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }

                                throw new global::LangSmith.ApiException<global::LangSmith.RunsErrorResponse>(
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_403,
                                    ResponseObject = __value_403,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // Conflict
                            if ((int)__response.StatusCode == 409)
                            {
                                string? __content_409 = null;
                                global::System.Exception? __exception_409 = null;
                                global::LangSmith.RunsErrorResponse? __value_409 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_409 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_409 = global::LangSmith.RunsErrorResponse.FromJson(__content_409, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_409 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_409 = global::LangSmith.RunsErrorResponse.FromJson(__content_409, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_409 = __ex;
                                }

                                throw new global::LangSmith.ApiException<global::LangSmith.RunsErrorResponse>(
                                    message: __content_409 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_409,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_409,
                                    ResponseObject = __value_409,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // Unprocessable Entity
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::LangSmith.RunsErrorResponse? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::LangSmith.RunsErrorResponse.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::LangSmith.RunsErrorResponse.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }

                                throw new global::LangSmith.ApiException<global::LangSmith.RunsErrorResponse>(
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_422,
                                    ResponseObject = __value_422,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // Too Many Requests
                            if ((int)__response.StatusCode == 429)
                            {
                                string? __content_429 = null;
                                global::System.Exception? __exception_429 = null;
                                global::LangSmith.RunsErrorResponse? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::LangSmith.RunsErrorResponse.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::LangSmith.RunsErrorResponse.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }

                                throw new global::LangSmith.ApiException<global::LangSmith.RunsErrorResponse>(
                                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_429,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_429,
                                    ResponseObject = __value_429,
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
                                ProcessIngestRunsMultipartResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        (global::System.Collections.Generic.Dictionary<string, string>?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.Dictionary<string, string>), JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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

                                    return
                                        (global::System.Collections.Generic.Dictionary<string, string>?)await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.Dictionary<string, string>), JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
        /// <summary>
        /// Ingest Runs (Multipart)<br/>
        /// Ingests multiple runs, feedback objects, and binary attachments in a single `multipart/form-data` request.<br/>
        /// **Part‑name pattern**: `&lt;event&gt;.&lt;run_id&gt;[.&lt;field&gt;]` where `event` ∈ {`post`, `patch`, `feedback`, `attachment`}.<br/>
        /// * `post|patch.&lt;run_id&gt;` – JSON run payload.<br/>
        /// * `post|patch.&lt;run_id&gt;.&lt;field&gt;` – out‑of‑band run data (`inputs`, `outputs`, `events`, `error`, `extra`, `serialized`).<br/>
        /// * `feedback.&lt;run_id&gt;` – JSON feedback payload (must include `trace_id`).<br/>
        /// * `attachment.&lt;run_id&gt;.&lt;filename&gt;` – arbitrary binary attachment stored in S3.<br/>
        /// **Headers**: every part must set `Content-Type` **and** either a `Content-Length` header or `length` parameter. Per‑part `Content-Encoding` is **not** allowed; the top‑level request may be `Content-Encoding: gzip` or `Content-Encoding: zstd`.<br/>
        /// **Best performance** for high‑volume ingestion.
        /// </summary>
        /// <param name="post_runId_">
        /// Run to create (JSON)
        /// </param>
        /// <param name="post_runId_name">
        /// Run to create (JSON)
        /// </param>
        /// <param name="patch_runId_">
        /// Run to update (JSON)
        /// </param>
        /// <param name="patch_runId_name">
        /// Run to update (JSON)
        /// </param>
        /// <param name="post_runId_Inputs">
        /// Large inputs object (JSON) stored out‑of‑band
        /// </param>
        /// <param name="post_runId_Inputsname">
        /// Large inputs object (JSON) stored out‑of‑band
        /// </param>
        /// <param name="patch_runId_Outputs">
        /// Large outputs object (JSON) stored out‑of‑band
        /// </param>
        /// <param name="patch_runId_Outputsname">
        /// Large outputs object (JSON) stored out‑of‑band
        /// </param>
        /// <param name="feedback_runId_">
        /// Feedback object (JSON) – must include trace_id
        /// </param>
        /// <param name="feedback_runId_name">
        /// Feedback object (JSON) – must include trace_id
        /// </param>
        /// <param name="attachment_runId__filename_">
        /// Binary attachment linked to run {run_id}
        /// </param>
        /// <param name="attachment_runId__filename_name">
        /// Binary attachment linked to run {run_id}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> IngestRunsMultipartAsync(
            byte[]? post_runId_ = default,
            string? post_runId_name = default,
            byte[]? patch_runId_ = default,
            string? patch_runId_name = default,
            byte[]? post_runId_Inputs = default,
            string? post_runId_Inputsname = default,
            byte[]? patch_runId_Outputs = default,
            string? patch_runId_Outputsname = default,
            byte[]? feedback_runId_ = default,
            string? feedback_runId_name = default,
            byte[]? attachment_runId__filename_ = default,
            string? attachment_runId__filename_name = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::LangSmith.CreateRunsMultipartRequest
            {
                Post_runId_ = post_runId_,
                Post_runId_name = post_runId_name,
                Patch_runId_ = patch_runId_,
                Patch_runId_name = patch_runId_name,
                Post_runId_Inputs = post_runId_Inputs,
                Post_runId_Inputsname = post_runId_Inputsname,
                Patch_runId_Outputs = patch_runId_Outputs,
                Patch_runId_Outputsname = patch_runId_Outputsname,
                Feedback_runId_ = feedback_runId_,
                Feedback_runId_name = feedback_runId_name,
                Attachment_runId__filename_ = attachment_runId__filename_,
                Attachment_runId__filename_name = attachment_runId__filename_name,
            };

            return await IngestRunsMultipartAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}