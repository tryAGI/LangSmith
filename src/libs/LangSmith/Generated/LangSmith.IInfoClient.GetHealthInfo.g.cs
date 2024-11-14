#nullable enable

namespace LangSmith
{
    public partial interface IInfoClient
    {
        /// <summary>
        /// Get Health Info<br/>
        /// Get health information about the current deployment of LangSmith.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.HealthInfoGetResponse> GetHealthInfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}