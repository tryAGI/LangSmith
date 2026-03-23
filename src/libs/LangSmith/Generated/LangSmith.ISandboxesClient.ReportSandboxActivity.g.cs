#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Report sandbox activity<br/>
        /// Batch-report activity for sandboxes so their idle TTL deadlines are extended.<br/>
        /// Called by the sandbox-router via X-Service-Key authentication.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesBatchActivityResponse> ReportSandboxActivityAsync(

            global::LangSmith.SandboxesBatchActivityRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Report sandbox activity<br/>
        /// Batch-report activity for sandboxes so their idle TTL deadlines are extended.<br/>
        /// Called by the sandbox-router via X-Service-Key authentication.
        /// </summary>
        /// <param name="activities"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesBatchActivityResponse> ReportSandboxActivityAsync(
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesActivityReport> activities,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}