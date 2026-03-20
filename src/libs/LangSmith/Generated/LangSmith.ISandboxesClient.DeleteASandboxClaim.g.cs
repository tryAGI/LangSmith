#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Delete a sandbox claim<br/>
        /// Delete a sandbox claim by name. Deletes both the K8s CRD and the DB record.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteASandboxClaimAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}