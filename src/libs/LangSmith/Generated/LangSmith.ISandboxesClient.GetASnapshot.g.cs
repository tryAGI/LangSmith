#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Get a snapshot<br/>
        /// Get a sandbox snapshot by ID.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesSnapshotResponse> GetASnapshotAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}