#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// [Beta] Clone a volume<br/>
        /// **Beta:** This API is in active development and may change without notice. Requires sandbox volumes to be enabled for your workspace. Create a new volume holding a copy-on-write copy of an existing one. A volume attached read-write to a sandbox that is not stopped cannot be cloned. Only the volume's creator, or a role with sandboxes:exec, may clone it.
        /// </summary>
        /// <param name="volume"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesVolumeResponse> CloneAVolumeAsync(
            string volume,

            global::LangSmith.SandboxesCloneVolumePayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Beta] Clone a volume<br/>
        /// **Beta:** This API is in active development and may change without notice. Requires sandbox volumes to be enabled for your workspace. Create a new volume holding a copy-on-write copy of an existing one. A volume attached read-write to a sandbox that is not stopped cannot be cloned. Only the volume's creator, or a role with sandboxes:exec, may clone it.
        /// </summary>
        /// <param name="volume"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SandboxesVolumeResponse>> CloneAVolumeAsResponseAsync(
            string volume,

            global::LangSmith.SandboxesCloneVolumePayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Beta] Clone a volume<br/>
        /// **Beta:** This API is in active development and may change without notice. Requires sandbox volumes to be enabled for your workspace. Create a new volume holding a copy-on-write copy of an existing one. A volume attached read-write to a sandbox that is not stopped cannot be cloned. Only the volume's creator, or a role with sandboxes:exec, may clone it.
        /// </summary>
        /// <param name="volume"></param>
        /// <param name="description"></param>
        /// <param name="labels"></param>
        /// <param name="name">
        /// Name of the new volume, unique within the workspace.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesVolumeResponse> CloneAVolumeAsync(
            string volume,
            string name,
            string? description = default,
            global::System.Collections.Generic.Dictionary<string, string>? labels = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}