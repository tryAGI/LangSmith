#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// [Beta] Update a volume<br/>
        /// **Beta:** This API is in active development and may change without notice. Requires sandbox volumes to be enabled for your workspace. Update a volume's description or labels. Each field sent replaces the stored value; omitted fields are unchanged. Null, an empty description, or an empty labels object clears it. Only the volume's creator, or a role with sandboxes:exec, may update it.
        /// </summary>
        /// <param name="volume"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesVolumeResponse> UpdateAVolumeAsync(
            string volume,

            global::LangSmith.SandboxesUpdateVolumePayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Beta] Update a volume<br/>
        /// **Beta:** This API is in active development and may change without notice. Requires sandbox volumes to be enabled for your workspace. Update a volume's description or labels. Each field sent replaces the stored value; omitted fields are unchanged. Null, an empty description, or an empty labels object clears it. Only the volume's creator, or a role with sandboxes:exec, may update it.
        /// </summary>
        /// <param name="volume"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SandboxesVolumeResponse>> UpdateAVolumeAsResponseAsync(
            string volume,

            global::LangSmith.SandboxesUpdateVolumePayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Beta] Update a volume<br/>
        /// **Beta:** This API is in active development and may change without notice. Requires sandbox volumes to be enabled for your workspace. Update a volume's description or labels. Each field sent replaces the stored value; omitted fields are unchanged. Null, an empty description, or an empty labels object clears it. Only the volume's creator, or a role with sandboxes:exec, may update it.
        /// </summary>
        /// <param name="volume"></param>
        /// <param name="description">
        /// Description replaces the description; null or an empty string clears it.
        /// </param>
        /// <param name="labels">
        /// Labels replaces every label; null or an empty object clears them.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesVolumeResponse> UpdateAVolumeAsync(
            string volume,
            string? description = default,
            global::System.Collections.Generic.Dictionary<string, string>? labels = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}