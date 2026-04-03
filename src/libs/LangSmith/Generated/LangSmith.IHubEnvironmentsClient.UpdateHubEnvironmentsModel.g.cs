#nullable enable

namespace LangSmith
{
    public partial interface IHubEnvironmentsClient
    {
        /// <summary>
        /// Update hub environments model<br/>
        /// Replaces the environments array on an existing model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.HubEnvironmentsHubEnvironmentsModel> UpdateHubEnvironmentsModelAsync(

            global::LangSmith.HubEnvironmentsUpdateEnvironmentsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update hub environments model<br/>
        /// Replaces the environments array on an existing model.
        /// </summary>
        /// <param name="environments"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.HubEnvironmentsHubEnvironmentsModel> UpdateHubEnvironmentsModelAsync(
            global::System.Collections.Generic.IList<global::LangSmith.HubEnvironmentsEnvironmentEntry> environments,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}