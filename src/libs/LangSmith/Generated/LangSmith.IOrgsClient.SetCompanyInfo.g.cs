#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Set Company Info
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SetCompanyInfoAsync(
            global::LangSmith.StripeBusinessInfoInput request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set Company Info
        /// </summary>
        /// <param name="companyInfo">
        /// Stripe customer billing information.
        /// </param>
        /// <param name="taxId">
        /// Stripe tax ID.
        /// </param>
        /// <param name="invoiceEmail"></param>
        /// <param name="isBusiness">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SetCompanyInfoAsync(
            global::LangSmith.StripeBusinessBillingInfo? companyInfo = default,
            global::LangSmith.StripeTaxId? taxId = default,
            string? invoiceEmail = default,
            bool? isBusiness = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}