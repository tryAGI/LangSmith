#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Set Default Sso Provision<br/>
        /// Set the current organization as the default for SSO provisioning in self-hosted environments.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SetDefaultSsoProvisionAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}