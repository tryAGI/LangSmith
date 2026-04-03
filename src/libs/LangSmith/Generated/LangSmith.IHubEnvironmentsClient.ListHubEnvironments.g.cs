#nullable enable

namespace LangSmith
{
    public partial interface IHubEnvironmentsClient
    {
        /// <summary>
        /// List hub environments<br/>
        /// Returns the hub environments model for the current tenant.<br/>
        /// Returns 404 if no custom configuration exists.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.HubEnvironmentsHubEnvironmentsModel> ListHubEnvironmentsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}