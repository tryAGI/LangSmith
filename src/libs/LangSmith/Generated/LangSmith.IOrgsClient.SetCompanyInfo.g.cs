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
        global::System.Threading.Tasks.Task<global::LangSmith.SetCompanyInfoApiV1OrgsCurrentBusinessInfoPostResponse> SetCompanyInfoAsync(
            global::LangSmith.StripeBusinessInfoInput request,
            global::System.Threading.CancellationToken cancellationToken = default);

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
        global::System.Threading.Tasks.Task<global::LangSmith.SetCompanyInfoApiV1OrgsCurrentBusinessInfoPostResponse> SetCompanyInfoAsync(
            global::LangSmith.AnyOf<global::LangSmith.StripeBusinessBillingInfo, object>? companyInfo = default,
            global::LangSmith.AnyOf<global::LangSmith.StripeTaxId, object>? taxId = default,
            global::LangSmith.AnyOf<string, object>? invoiceEmail = default,
            bool? isBusiness = false,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}