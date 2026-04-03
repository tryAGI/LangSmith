#nullable enable

namespace LangSmith
{
    public partial interface IHubEnvironmentsClient
    {
        /// <summary>
        /// Create hub environments model<br/>
        /// Creates the hub environments configuration for the current tenant.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.HubEnvironmentsHubEnvironmentsModel> CreateHubEnvironmentsModelAsync(

            global::LangSmith.HubEnvironmentsCreateEnvironmentsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create hub environments model<br/>
        /// Creates the hub environments configuration for the current tenant.
        /// </summary>
        /// <param name="environments"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.HubEnvironmentsHubEnvironmentsModel> CreateHubEnvironmentsModelAsync(
            global::System.Collections.Generic.IList<global::LangSmith.HubEnvironmentsEnvironmentEntry> environments,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}