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
        /// <param name="colorScheme">
        /// Enum for acceptable color schemes of dashboards.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OrganizationDashboardSchema> GetDashboardAsync(
            global::LangSmith.OrganizationDashboardType type,
            global::LangSmith.OrganizationDashboardColorScheme colorScheme,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}