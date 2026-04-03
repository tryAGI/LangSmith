#nullable enable

namespace LangSmith
{
    public partial interface IHubEnvironmentsClient
    {
        /// <summary>
        /// Delete hub environments model<br/>
        /// Deletes the hub environments configuration. Tenant reverts to defaults.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> DeleteHubEnvironmentsModelAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}