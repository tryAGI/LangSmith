#nullable enable

namespace LangSmith
{
    public partial interface IServiceAccountsClient
    {
        /// <summary>
        /// Get Service Accounts<br/>
        /// Get the current organization's service accounts.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.ServiceAccount>> GetServiceAccountsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}