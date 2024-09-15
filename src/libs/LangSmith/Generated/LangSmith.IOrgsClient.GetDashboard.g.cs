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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OrganizationDashboardSchema> GetDashboardAsync(
            global::LangSmith.OrganizationDashboardType type,
            global::LangSmith.AnyOf<global::LangSmith.OrganizationDashboardColorScheme?, object> colorScheme,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}