#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get Organization Billing Info
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OrganizationBillingInfo> GetOrganizationBillingInfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}