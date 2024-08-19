
#nullable enable

namespace LangSmith
{
    public partial class OrgsClient
    {
        partial void PrepareChangePaymentPlanApiV1OrgsCurrentPlanPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.ChangePaymentPlanSchema request);
        partial void PrepareChangePaymentPlanApiV1OrgsCurrentPlanPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.ChangePaymentPlanSchema request);
        partial void ProcessChangePaymentPlanApiV1OrgsCurrentPlanPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessChangePaymentPlanApiV1OrgsCurrentPlanPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Change Payment Plan
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.ChangePaymentPlanApiV1OrgsCurrentPlanPostResponse> ChangePaymentPlanApiV1OrgsCurrentPlanPostAsync(
            global::LangSmith.ChangePaymentPlanSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareChangePaymentPlanApiV1OrgsCurrentPlanPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/orgs/current/plan", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.ChangePaymentPlanSchema);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareChangePaymentPlanApiV1OrgsCurrentPlanPostRequest(
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
            ProcessChangePaymentPlanApiV1OrgsCurrentPlanPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessChangePaymentPlanApiV1OrgsCurrentPlanPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.ChangePaymentPlanApiV1OrgsCurrentPlanPostResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Change Payment Plan
        /// </summary>
        /// <param name="tier">
        /// Enum for payment plans that the user can change to. Developer plans are permanent and enterprise plans will be changed manually.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.ChangePaymentPlanApiV1OrgsCurrentPlanPostResponse> ChangePaymentPlanApiV1OrgsCurrentPlanPostAsync(
            global::LangSmith.ChangePaymentPlanReq tier,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.ChangePaymentPlanSchema
            {
                Tier = tier,
            };

            return await ChangePaymentPlanApiV1OrgsCurrentPlanPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}