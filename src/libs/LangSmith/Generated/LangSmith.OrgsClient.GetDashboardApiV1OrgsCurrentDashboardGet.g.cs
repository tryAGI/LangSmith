
#nullable enable

namespace LangSmith
{
    public partial class OrgsClient
    {
        partial void PrepareGetDashboardApiV1OrgsCurrentDashboardGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::LangSmith.OrganizationDashboardType type,
            ref global::System.AnyOf<global::LangSmith.OrganizationDashboardColorScheme?, object> colorScheme);
        partial void PrepareGetDashboardApiV1OrgsCurrentDashboardGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.OrganizationDashboardType type,
            global::System.AnyOf<global::LangSmith.OrganizationDashboardColorScheme?, object> colorScheme);
        partial void ProcessGetDashboardApiV1OrgsCurrentDashboardGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetDashboardApiV1OrgsCurrentDashboardGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Dashboard
        /// </summary>
        /// <param name="type">
        /// Enum for acceptable types of dashboards.
        /// </param>
        /// <param name="colorScheme"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.OrganizationDashboardSchema> GetDashboardApiV1OrgsCurrentDashboardGetAsync(
            global::LangSmith.OrganizationDashboardType type,
            global::System.AnyOf<global::LangSmith.OrganizationDashboardColorScheme?, object> colorScheme,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetDashboardApiV1OrgsCurrentDashboardGetArguments(
                httpClient: _httpClient,
                type: ref type,
                colorScheme: ref colorScheme);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/orgs/current/dashboard?type={type}&color_scheme={colorScheme}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetDashboardApiV1OrgsCurrentDashboardGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                type: type,
                colorScheme: colorScheme);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetDashboardApiV1OrgsCurrentDashboardGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetDashboardApiV1OrgsCurrentDashboardGetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.OrganizationDashboardSchema) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}