#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// [Beta] Create a volume<br/>
        /// **Beta:** This API is in active development and may change without notice. Requires sandbox volumes to be enabled for your workspace. Create an empty volume that can be attached to sandboxes at a mount path. The size is rounded up to a whole GiB.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesVolumeResponse> CreateAVolumeAsync(

            global::LangSmith.SandboxesCreateVolumePayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Beta] Create a volume<br/>
        /// **Beta:** This API is in active development and may change without notice. Requires sandbox volumes to be enabled for your workspace. Create an empty volume that can be attached to sandboxes at a mount path. The size is rounded up to a whole GiB.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SandboxesVolumeResponse>> CreateAVolumeAsResponseAsync(

            global::LangSmith.SandboxesCreateVolumePayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Beta] Create a volume<br/>
        /// **Beta:** This API is in active development and may change without notice. Requires sandbox volumes to be enabled for your workspace. Create an empty volume that can be attached to sandboxes at a mount path. The size is rounded up to a whole GiB.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="labels"></param>
        /// <param name="name">
        /// Name is unique within the workspace.
        /// </param>
        /// <param name="sizeBytes">
        /// SizeBytes is the volume's capacity, rounded up to a whole GiB.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesVolumeResponse> CreateAVolumeAsync(
            string name,
            long sizeBytes,
            string? description = default,
            global::System.Collections.Generic.Dictionary<string, string>? labels = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}