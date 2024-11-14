#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Create Stripe Account Links Endpoint<br/>
        /// Kick off a Stripe account link flow.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateStripeAccountLinksEndpointAsync(
            global::LangSmith.StripeAccountLinksCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Stripe Account Links Endpoint<br/>
        /// Kick off a Stripe account link flow.
        /// </summary>
        /// <param name="successPath"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateStripeAccountLinksEndpointAsync(
            string successPath,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}