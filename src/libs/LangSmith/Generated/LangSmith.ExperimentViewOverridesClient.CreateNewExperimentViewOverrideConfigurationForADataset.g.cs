
#nullable enable

namespace LangSmith
{
    public partial class ExperimentViewOverridesClient
    {
        partial void PrepareCreateNewExperimentViewOverrideConfigurationForADatasetArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.ExperimentViewOverridesExperimentViewOverridePostRequest request);
        partial void PrepareCreateNewExperimentViewOverrideConfigurationForADatasetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.ExperimentViewOverridesExperimentViewOverridePostRequest request);
        partial void ProcessCreateNewExperimentViewOverrideConfigurationForADatasetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateNewExperimentViewOverrideConfigurationForADatasetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create new experiment view override configuration for a dataset<br/>
        /// Creates a new experiment view override configuration for a dataset with column display settings.<br/>
        /// This endpoint allows you to customize how experiment results are displayed by configuring<br/>
        /// column-specific overrides including colors, precision, and visibility.<br/>
        /// The request must include a 'column_overrides' array with at least one override configuration.<br/>
        /// Each column override can specify:<br/>
        /// - column: Required field name (must start with inputs, outputs, reference_outputs, feedback, metrics, attachments, or metadata)<br/>
        /// - color_gradient: Optional array of [number, color] tuples for numeric data visualization<br/>
        /// - precision: Optional number (1-6) for decimal places in numeric columns<br/>
        /// - hide: Optional boolean to control column visibility<br/>
        /// Example request body:<br/>
        /// {<br/>
        /// "column_overrides": [<br/>
        /// {<br/>
        /// "column": "outputs.accuracy",<br/>
        /// "color_gradient": [[0.0, "#ff0000"], [0.5, "#ffff00"], [1.0, "#00ff00"]],<br/>
        /// "precision": 3<br/>
        /// },<br/>
        /// {<br/>
        /// "column": "inputs.model_type",<br/>
        /// "hide": false<br/>
        /// }<br/>
        /// ]<br/>
        /// }<br/>
        /// This operation fails if an override already exists for the dataset (use PATCH to update).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.ExperimentViewOverridesExperimentViewOverride> CreateNewExperimentViewOverrideConfigurationForADatasetAsync(
            global::LangSmith.ExperimentViewOverridesExperimentViewOverridePostRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateNewExperimentViewOverrideConfigurationForADatasetArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::LangSmith.PathBuilder(
                path: "/datasets/{dataset_id}/experiment-view-overrides",
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateNewExperimentViewOverrideConfigurationForADatasetRequest(
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
            ProcessCreateNewExperimentViewOverrideConfigurationForADatasetResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Invalid request data" example({"error":"column_overrides field is required"})
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::System.Collections.Generic.Dictionary<string, string>? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::System.Text.Json.JsonSerializer.Deserialize(__content_400, typeof(global::System.Collections.Generic.Dictionary<string, string>), JsonSerializerContext) as global::System.Collections.Generic.Dictionary<string, string>;
                    }
                    else
                    {
                        var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = await global::System.Text.Json.JsonSerializer.DeserializeAsync(__contentStream_400, typeof(global::System.Collections.Generic.Dictionary<string, string>), JsonSerializerContext).ConfigureAwait(false) as global::System.Collections.Generic.Dictionary<string, string>;
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
            // Unauthorized access" example({"error":"Unauthorized"})
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::System.Collections.Generic.Dictionary<string, string>? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::System.Text.Json.JsonSerializer.Deserialize(__content_401, typeof(global::System.Collections.Generic.Dictionary<string, string>), JsonSerializerContext) as global::System.Collections.Generic.Dictionary<string, string>;
                    }
                    else
                    {
                        var __contentStream_401 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = await global::System.Text.Json.JsonSerializer.DeserializeAsync(__contentStream_401, typeof(global::System.Collections.Generic.Dictionary<string, string>), JsonSerializerContext).ConfigureAwait(false) as global::System.Collections.Generic.Dictionary<string, string>;
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
            // Dataset not found" example({"error":"dataset not found or not accessible"})
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::System.Collections.Generic.Dictionary<string, string>? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::System.Text.Json.JsonSerializer.Deserialize(__content_404, typeof(global::System.Collections.Generic.Dictionary<string, string>), JsonSerializerContext) as global::System.Collections.Generic.Dictionary<string, string>;
                    }
                    else
                    {
                        var __contentStream_404 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = await global::System.Text.Json.JsonSerializer.DeserializeAsync(__contentStream_404, typeof(global::System.Collections.Generic.Dictionary<string, string>), JsonSerializerContext).ConfigureAwait(false) as global::System.Collections.Generic.Dictionary<string, string>;
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::LangSmith.ApiException<global::System.Collections.Generic.Dictionary<string, string>>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Override already exists" example({"error":"experiment view override already exists"})
            if ((int)__response.StatusCode == 409)
            {
                string? __content_409 = null;
                global::System.Exception? __exception_409 = null;
                global::System.Collections.Generic.Dictionary<string, string>? __value_409 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_409 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_409 = global::System.Text.Json.JsonSerializer.Deserialize(__content_409, typeof(global::System.Collections.Generic.Dictionary<string, string>), JsonSerializerContext) as global::System.Collections.Generic.Dictionary<string, string>;
                    }
                    else
                    {
                        var __contentStream_409 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_409 = await global::System.Text.Json.JsonSerializer.DeserializeAsync(__contentStream_409, typeof(global::System.Collections.Generic.Dictionary<string, string>), JsonSerializerContext).ConfigureAwait(false) as global::System.Collections.Generic.Dictionary<string, string>;
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_409 = __ex;
                }

                throw new global::LangSmith.ApiException<global::System.Collections.Generic.Dictionary<string, string>>(
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
            // Validation error" example({"error":"column name at index 0 must start with one of: inputs, outputs, reference_outputs, feedback, metrics, attachments, metadata"})
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::System.Collections.Generic.Dictionary<string, string>? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::System.Text.Json.JsonSerializer.Deserialize(__content_422, typeof(global::System.Collections.Generic.Dictionary<string, string>), JsonSerializerContext) as global::System.Collections.Generic.Dictionary<string, string>;
                    }
                    else
                    {
                        var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = await global::System.Text.Json.JsonSerializer.DeserializeAsync(__contentStream_422, typeof(global::System.Collections.Generic.Dictionary<string, string>), JsonSerializerContext).ConfigureAwait(false) as global::System.Collections.Generic.Dictionary<string, string>;
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::LangSmith.ApiException<global::System.Collections.Generic.Dictionary<string, string>>(
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
            // Internal server error" example({"error":"internal server error"})
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                global::System.Collections.Generic.Dictionary<string, string>? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::System.Text.Json.JsonSerializer.Deserialize(__content_500, typeof(global::System.Collections.Generic.Dictionary<string, string>), JsonSerializerContext) as global::System.Collections.Generic.Dictionary<string, string>;
                    }
                    else
                    {
                        var __contentStream_500 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = await global::System.Text.Json.JsonSerializer.DeserializeAsync(__contentStream_500, typeof(global::System.Collections.Generic.Dictionary<string, string>), JsonSerializerContext).ConfigureAwait(false) as global::System.Collections.Generic.Dictionary<string, string>;
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
                ProcessCreateNewExperimentViewOverrideConfigurationForADatasetResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::LangSmith.ExperimentViewOverridesExperimentViewOverride.FromJson(__content, JsonSerializerContext) ??
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
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::LangSmith.ExperimentViewOverridesExperimentViewOverride.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
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
            }
        }

        /// <summary>
        /// Create new experiment view override configuration for a dataset<br/>
        /// Creates a new experiment view override configuration for a dataset with column display settings.<br/>
        /// This endpoint allows you to customize how experiment results are displayed by configuring<br/>
        /// column-specific overrides including colors, precision, and visibility.<br/>
        /// The request must include a 'column_overrides' array with at least one override configuration.<br/>
        /// Each column override can specify:<br/>
        /// - column: Required field name (must start with inputs, outputs, reference_outputs, feedback, metrics, attachments, or metadata)<br/>
        /// - color_gradient: Optional array of [number, color] tuples for numeric data visualization<br/>
        /// - precision: Optional number (1-6) for decimal places in numeric columns<br/>
        /// - hide: Optional boolean to control column visibility<br/>
        /// Example request body:<br/>
        /// {<br/>
        /// "column_overrides": [<br/>
        /// {<br/>
        /// "column": "outputs.accuracy",<br/>
        /// "color_gradient": [[0.0, "#ff0000"], [0.5, "#ffff00"], [1.0, "#00ff00"]],<br/>
        /// "precision": 3<br/>
        /// },<br/>
        /// {<br/>
        /// "column": "inputs.model_type",<br/>
        /// "hide": false<br/>
        /// }<br/>
        /// ]<br/>
        /// }<br/>
        /// This operation fails if an override already exists for the dataset (use PATCH to update).
        /// </summary>
        /// <param name="columnOverrides"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.ExperimentViewOverridesExperimentViewOverride> CreateNewExperimentViewOverrideConfigurationForADatasetAsync(
            global::System.Collections.Generic.IList<global::LangSmith.ExperimentViewOverridesColumnOverride> columnOverrides,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::LangSmith.ExperimentViewOverridesExperimentViewOverridePostRequest
            {
                ColumnOverrides = columnOverrides,
            };

            return await CreateNewExperimentViewOverrideConfigurationForADatasetAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}