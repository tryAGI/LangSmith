#nullable enable

namespace LangSmith
{
    public partial interface IAwsMarketplaceClient
    {
        /// <summary>
        /// AWS Marketplace fulfillment URL registration<br/>
        /// Receives the x-amzn-marketplace-token posted by AWS Marketplace when a customer clicks "Set Up Account", resolves the customer identity, fetches entitlements, stores both in the DB, and redirects to the thank-you page.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task AwsMarketplaceFulfillmentUrlRegistrationAsync(

            global::LangSmith.CreateAwsMarketplaceRegisterRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AWS Marketplace fulfillment URL registration<br/>
        /// Receives the x-amzn-marketplace-token posted by AWS Marketplace when a customer clicks "Set Up Account", resolves the customer identity, fetches entitlements, stores both in the DB, and redirects to the thank-you page.
        /// </summary>
        /// <param name="xAmznMarketplaceToken">
        /// Registration token from AWS Marketplace
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task AwsMarketplaceFulfillmentUrlRegistrationAsync(
            string xAmznMarketplaceToken,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}