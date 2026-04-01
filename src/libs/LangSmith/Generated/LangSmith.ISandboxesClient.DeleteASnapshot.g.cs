#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Delete a snapshot<br/>
        /// Delete a snapshot by ID. The ext4 rootfs is removed from JuiceFS asynchronously.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteASnapshotAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}