#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Confirm Checkout Session Completion Endpoint<br/>
        /// Complete a Stripe checkout session flow.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ConfirmCheckoutSessionCompletionEndpointAsync(
            global::LangSmith.StripeCheckoutSessionsConfirm request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Confirm Checkout Session Completion Endpoint<br/>
        /// Complete a Stripe checkout session flow.
        /// </summary>
        /// <param name="stripeSessionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ConfirmCheckoutSessionCompletionEndpointAsync(
            string stripeSessionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}