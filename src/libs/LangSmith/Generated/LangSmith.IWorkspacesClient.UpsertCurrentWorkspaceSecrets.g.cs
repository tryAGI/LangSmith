#nullable enable

namespace LangSmith
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Upsert Current Workspace Secrets
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpsertCurrentWorkspaceSecretsAsync(
            global::System.Collections.Generic.IList<global::LangSmith.SecretUpsert> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}