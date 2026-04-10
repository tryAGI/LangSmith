#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get Dashboard
        /// </summary>
        /// <param name="type">
        /// Enum for acceptable types of dashboards.
        /// </param>
        /// <param name="colorScheme"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OrganizationDashboardSchema> GetDashboardAsync(
            global::LangSmith.OrganizationDashboardType type,
            global::LangSmith.OrganizationDashboardColorScheme? colorScheme,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}