#nullable enable

namespace LangSmith
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Get Current Workspace Encrypted Secrets<br/>
        /// Get encrypted workspace secrets for use with Fleet and external services.
        /// </summary>
        /// <param name="service">
        /// Service requesting encrypted secrets
        /// </param>
        /// <param name="keyNames">
        /// Optional list of workspace secret keys to return
        /// </param>
        /// <param name="expandIamRole">
        /// If true, expand AWS_IAM_ROLE_ARN into temporary credentials via STS<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.InternalSecretsResponse> GetCurrentWorkspaceEncryptedSecretsAsync(
            global::LangSmith.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetService service,
            global::System.Collections.Generic.IList<string>? keyNames = default,
            bool? expandIamRole = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}