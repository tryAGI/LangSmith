#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {

        /// <summary>
        /// Get a sandbox claim<br/>
        /// Retrieve a sandbox claim by name. Stale provisioning claims are auto-failed.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesClaimResponse> GetASandboxClaimAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}