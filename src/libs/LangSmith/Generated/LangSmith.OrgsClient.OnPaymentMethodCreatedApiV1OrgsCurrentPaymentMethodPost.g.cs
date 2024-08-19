
#nullable enable

namespace LangSmith
{
    public partial class OrgsClient
    {
        partial void PrepareOnPaymentMethodCreatedApiV1OrgsCurrentPaymentMethodPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.StripePaymentInformation request);
        partial void PrepareOnPaymentMethodCreatedApiV1OrgsCurrentPaymentMethodPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.StripePaymentInformation request);
        partial void ProcessOnPaymentMethodCreatedApiV1OrgsCurrentPaymentMethodPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOnPaymentMethodCreatedApiV1OrgsCurrentPaymentMethodPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// On Payment Method Created
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.OnPaymentMethodCreatedApiV1OrgsCurrentPaymentMethodPostResponse> OnPaymentMethodCreatedApiV1OrgsCurrentPaymentMethodPostAsync(
            global::LangSmith.StripePaymentInformation request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareOnPaymentMethodCreatedApiV1OrgsCurrentPaymentMethodPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/orgs/current/payment-method", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.StripePaymentInformation);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareOnPaymentMethodCreatedApiV1OrgsCurrentPaymentMethodPostRequest(
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
            ProcessOnPaymentMethodCreatedApiV1OrgsCurrentPaymentMethodPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessOnPaymentMethodCreatedApiV1OrgsCurrentPaymentMethodPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.OnPaymentMethodCreatedApiV1OrgsCurrentPaymentMethodPostResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// On Payment Method Created
        /// </summary>
        /// <param name="billingInfo">
        /// Stripe customer billing information.
        /// </param>
        /// <param name="setupIntent"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.OnPaymentMethodCreatedApiV1OrgsCurrentPaymentMethodPostResponse> OnPaymentMethodCreatedApiV1OrgsCurrentPaymentMethodPostAsync(
            global::LangSmith.StripeCustomerBillingInfo billingInfo,
            string setupIntent,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.StripePaymentInformation
            {
                BillingInfo = billingInfo,
                SetupIntent = setupIntent,
            };

            return await OnPaymentMethodCreatedApiV1OrgsCurrentPaymentMethodPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}