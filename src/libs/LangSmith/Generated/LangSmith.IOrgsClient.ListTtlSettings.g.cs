#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List Ttl Settings<br/>
        /// List out the configured Ttl settings for a given org (org-level and tenant-level).
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.TtlSettings>> ListTtlSettingsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}