#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// [Beta] Delete a volume<br/>
        /// **Beta:** This API is in active development and may change without notice. Requires sandbox volumes to be enabled for your workspace. Delete a volume and its data. A volume attached to any sandbox cannot be deleted. Storage is reclaimed asynchronously. Only the volume's creator, or a role with sandboxes:exec, may delete it.
        /// </summary>
        /// <param name="volume"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task DeleteAVolumeAsync(
            string volume,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Beta] Delete a volume<br/>
        /// **Beta:** This API is in active development and may change without notice. Requires sandbox volumes to be enabled for your workspace. Delete a volume and its data. A volume attached to any sandbox cannot be deleted. Storage is reclaimed asynchronously. Only the volume's creator, or a role with sandboxes:exec, may delete it.
        /// </summary>
        /// <param name="volume"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> DeleteAVolumeAsResponseAsync(
            string volume,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}