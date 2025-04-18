#nullable enable

namespace LangSmith
{
    public partial interface ITtlSettingsClient
    {
        /// <summary>
        /// List Ttl Settings<br/>
        /// List out the configured TTL settings for a given tenant.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.TTLSettings>> ListTtlSettingsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}