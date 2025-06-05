
#nullable enable

namespace LangSmith
{
    public partial class RunsClient
    {
        partial void PrepareIngestRunsMultipartArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.Request2 request);
        partial void PrepareIngestRunsMultipartRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.Request2 request);
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
        /// **Headers**: every part must set `Content-Type` **and** either a `Content-Length` header or `length` parameter. Per‑part `Content-Encoding` is **not** allowed; the top‑level request may be `Content-Encoding: zstd`.<br/>
        /// **Best performance** for high‑volume ingestion.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> IngestRunsMultipartAsync(
            global::LangSmith.Request2 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareIngestRunsMultipartArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::LangSmith.PathBuilder(
                path: "/runs/multipart",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

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
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (request.Post_runId_ != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.Post_runId_ ?? global::System.Array.Empty<byte>()),
                    name: "post.{run_id}",
                    fileName: request.Post_runId_name ?? string.Empty);
            } 
            if (request.Patch_runId_ != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.Patch_runId_ ?? global::System.Array.Empty<byte>()),
                    name: "patch.{run_id}",
                    fileName: request.Patch_runId_name ?? string.Empty);
            } 
            if (request.Post_runId_Inputs != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.Post_runId_Inputs ?? global::System.Array.Empty<byte>()),
                    name: "post.{run_id}.inputs",
                    fileName: request.Post_runId_Inputsname ?? string.Empty);
            } 
            if (request.Patch_runId_Outputs != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.Patch_runId_Outputs ?? global::System.Array.Empty<byte>()),
                    name: "patch.{run_id}.outputs",
                    fileName: request.Patch_runId_Outputsname ?? string.Empty);
            } 
            if (request.Feedback_runId_ != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.Feedback_runId_ ?? global::System.Array.Empty<byte>()),
                    name: "feedback.{run_id}",
                    fileName: request.Feedback_runId_name ?? string.Empty);
            } 
            if (request.Attachment_runId__filename_ != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Attachment_runId__filename_}"),
                    name: "attachment.{run_id}.{filename}");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareIngestRunsMultipartRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessIngestRunsMultipartResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad Request
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::LangSmith.RunsErrorResponse? __value_400 = null;
                if (ReadResponseAsString)
                {
                    __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = global::LangSmith.RunsErrorResponse.FromJson(__content_400, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = await global::LangSmith.RunsErrorResponse.FromJsonStreamAsync(__contentStream_400, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::LangSmith.ApiException<global::LangSmith.RunsErrorResponse>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
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
                global::LangSmith.RunsErrorResponse? __value_403 = null;
                if (ReadResponseAsString)
                {
                    __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_403 = global::LangSmith.RunsErrorResponse.FromJson(__content_403, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_403 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_403 = await global::LangSmith.RunsErrorResponse.FromJsonStreamAsync(__contentStream_403, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::LangSmith.ApiException<global::LangSmith.RunsErrorResponse>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
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
                global::LangSmith.RunsErrorResponse? __value_409 = null;
                if (ReadResponseAsString)
                {
                    __content_409 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_409 = global::LangSmith.RunsErrorResponse.FromJson(__content_409, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_409 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_409 = await global::LangSmith.RunsErrorResponse.FromJsonStreamAsync(__contentStream_409, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::LangSmith.ApiException<global::LangSmith.RunsErrorResponse>(
                    message: __content_409 ?? __response.ReasonPhrase ?? string.Empty,
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
                global::LangSmith.RunsErrorResponse? __value_422 = null;
                if (ReadResponseAsString)
                {
                    __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = global::LangSmith.RunsErrorResponse.FromJson(__content_422, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = await global::LangSmith.RunsErrorResponse.FromJsonStreamAsync(__contentStream_422, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::LangSmith.ApiException<global::LangSmith.RunsErrorResponse>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
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
                global::LangSmith.RunsErrorResponse? __value_429 = null;
                if (ReadResponseAsString)
                {
                    __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_429 = global::LangSmith.RunsErrorResponse.FromJson(__content_429, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_429 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_429 = await global::LangSmith.RunsErrorResponse.FromJsonStreamAsync(__contentStream_429, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::LangSmith.ApiException<global::LangSmith.RunsErrorResponse>(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
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

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
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
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
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

                return
                    global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.Dictionary<string, string>), JsonSerializerContext) as global::System.Collections.Generic.Dictionary<string, string> ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::LangSmith.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                return
                    await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.Dictionary<string, string>), JsonSerializerContext).ConfigureAwait(false) as global::System.Collections.Generic.Dictionary<string, string> ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
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
        /// **Headers**: every part must set `Content-Type` **and** either a `Content-Length` header or `length` parameter. Per‑part `Content-Encoding` is **not** allowed; the top‑level request may be `Content-Encoding: zstd`.<br/>
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::LangSmith.Request2
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
            };

            return await IngestRunsMultipartAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}