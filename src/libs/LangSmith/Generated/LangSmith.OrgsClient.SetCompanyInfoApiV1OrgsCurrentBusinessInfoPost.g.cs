
#nullable enable

namespace LangSmith
{
    public partial class OrgsClient
    {
        partial void PrepareSetCompanyInfoApiV1OrgsCurrentBusinessInfoPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.StripeBusinessInfoInput request);
        partial void PrepareSetCompanyInfoApiV1OrgsCurrentBusinessInfoPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.StripeBusinessInfoInput request);
        partial void ProcessSetCompanyInfoApiV1OrgsCurrentBusinessInfoPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSetCompanyInfoApiV1OrgsCurrentBusinessInfoPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Set Company Info
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.SetCompanyInfoApiV1OrgsCurrentBusinessInfoPostResponse> SetCompanyInfoApiV1OrgsCurrentBusinessInfoPostAsync(
            global::LangSmith.StripeBusinessInfoInput request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareSetCompanyInfoApiV1OrgsCurrentBusinessInfoPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/orgs/current/business-info", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.StripeBusinessInfoInput);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareSetCompanyInfoApiV1OrgsCurrentBusinessInfoPostRequest(
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
            ProcessSetCompanyInfoApiV1OrgsCurrentBusinessInfoPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessSetCompanyInfoApiV1OrgsCurrentBusinessInfoPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.SetCompanyInfoApiV1OrgsCurrentBusinessInfoPostResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Set Company Info
        /// </summary>
        /// <param name="companyInfo"></param>
        /// <param name="taxId"></param>
        /// <param name="invoiceEmail"></param>
        /// <param name="isBusiness">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.SetCompanyInfoApiV1OrgsCurrentBusinessInfoPostResponse> SetCompanyInfoApiV1OrgsCurrentBusinessInfoPostAsync(
            global::System.AnyOf<global::LangSmith.StripeBusinessBillingInfo, object>? companyInfo = default,
            global::System.AnyOf<global::LangSmith.StripeTaxId, object>? taxId = default,
            global::System.AnyOf<string, object>? invoiceEmail = default,
            bool isBusiness = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.StripeBusinessInfoInput
            {
                CompanyInfo = companyInfo,
                TaxId = taxId,
                InvoiceEmail = invoiceEmail,
                IsBusiness = isBusiness,
            };

            return await SetCompanyInfoApiV1OrgsCurrentBusinessInfoPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}