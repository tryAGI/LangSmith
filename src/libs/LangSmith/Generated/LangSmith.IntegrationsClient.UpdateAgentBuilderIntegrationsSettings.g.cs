
#nullable enable

namespace LangSmith
{
    public partial class IntegrationsClient
    {
        partial void PrepareUpdateAgentBuilderIntegrationsSettingsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.IntegrationsAgentBuilderIntegrationsUpdatePayload request);
        partial void PrepareUpdateAgentBuilderIntegrationsSettingsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.IntegrationsAgentBuilderIntegrationsUpdatePayload request);
        partial void ProcessUpdateAgentBuilderIntegrationsSettingsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateAgentBuilderIntegrationsSettingsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Agent Builder integrations settings<br/>
        /// Replaces default policy and integration overrides for the current workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.IntegrationsAgentBuilderIntegrationsPayload> UpdateAgentBuilderIntegrationsSettingsAsync(

            global::LangSmith.IntegrationsAgentBuilderIntegrationsUpdatePayload request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateAgentBuilderIntegrationsSettingsArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::LangSmith.PathBuilder(
                path: "/v1/agent-builder/integrations",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
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
            PrepareUpdateAgentBuilderIntegrationsSettingsRequest(
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
            ProcessUpdateAgentBuilderIntegrationsSettingsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad Request
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
            // Not Found
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
            // Internal Server Error
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
                ProcessUpdateAgentBuilderIntegrationsSettingsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::LangSmith.IntegrationsAgentBuilderIntegrationsPayload.FromJson(__content, JsonSerializerContext) ??
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
                        await global::LangSmith.IntegrationsAgentBuilderIntegrationsPayload.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Update Agent Builder integrations settings<br/>
        /// Replaces default policy and integration overrides for the current workspace.
        /// </summary>
        /// <param name="integrationOverrides"></param>
        /// <param name="integrationsEnabledByDefault"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.IntegrationsAgentBuilderIntegrationsPayload> UpdateAgentBuilderIntegrationsSettingsAsync(
            global::System.Collections.Generic.IList<global::LangSmith.IntegrationsIntegrationOverrideUpdate>? integrationOverrides = default,
            bool? integrationsEnabledByDefault = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::LangSmith.IntegrationsAgentBuilderIntegrationsUpdatePayload
            {
                IntegrationOverrides = integrationOverrides,
                IntegrationsEnabledByDefault = integrationsEnabledByDefault,
            };

            return await UpdateAgentBuilderIntegrationsSettingsAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}