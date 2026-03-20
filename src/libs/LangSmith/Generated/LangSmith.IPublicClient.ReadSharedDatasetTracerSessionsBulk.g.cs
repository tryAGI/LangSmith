#nullable enable

namespace LangSmith
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Read Shared Dataset Tracer Sessions Bulk<br/>
        /// Get sessions from multiple datasets using share tokens.
        /// </summary>
        /// <param name="shareTokens"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.TracerSession>> ReadSharedDatasetTracerSessionsBulkAsync(
            global::System.Collections.Generic.IList<string> shareTokens,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}