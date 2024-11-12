#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// On Payment Method Created
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OnPaymentMethodCreatedAsync(
            global::LangSmith.StripePaymentInformation request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// On Payment Method Created
        /// </summary>
        /// <param name="billingInfo">
        /// Stripe customer billing information.
        /// </param>
        /// <param name="setupIntent"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> OnPaymentMethodCreatedAsync(
            global::LangSmith.StripeCustomerBillingInfo billingInfo,
            string setupIntent,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}