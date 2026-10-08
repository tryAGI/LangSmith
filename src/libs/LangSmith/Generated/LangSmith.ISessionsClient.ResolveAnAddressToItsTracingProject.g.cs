#nullable enable

namespace LangSmith
{
    public partial interface ISessionsClient
    {
        /// <summary>
        /// [Beta] Resolve an address to its tracing project<br/>
        /// **Beta:** This endpoint is in active development and may change without notice. Returns the tracing project (session) an address names. An address is an AGENT (`id` and `environment`), an EXPERIMENT (`id`), or an EVALUATOR (no `id`: evaluator traces share one project per workspace). Send `kind` and `environment` in upper case, as listed; they are matched case-insensitively, while the Agent `id` is case-sensitive. An address that does not exist, or whose project you cannot read, is a 404. Pass the returned `session_id` to any endpoint that takes a project (session) ID. This is not supported on a BYOC data plane yet, and is a 501 there.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="id"></param>
        /// <param name="environment"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.AddressesResolveResponse> ResolveAnAddressToItsTracingProjectAsync(
            global::LangSmith.GetSessionsResolutionsKind kind,
            string? id = default,
            global::LangSmith.GetSessionsResolutionsEnvironment? environment = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Beta] Resolve an address to its tracing project<br/>
        /// **Beta:** This endpoint is in active development and may change without notice. Returns the tracing project (session) an address names. An address is an AGENT (`id` and `environment`), an EXPERIMENT (`id`), or an EVALUATOR (no `id`: evaluator traces share one project per workspace). Send `kind` and `environment` in upper case, as listed; they are matched case-insensitively, while the Agent `id` is case-sensitive. An address that does not exist, or whose project you cannot read, is a 404. Pass the returned `session_id` to any endpoint that takes a project (session) ID. This is not supported on a BYOC data plane yet, and is a 501 there.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="id"></param>
        /// <param name="environment"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.AddressesResolveResponse>> ResolveAnAddressToItsTracingProjectAsResponseAsync(
            global::LangSmith.GetSessionsResolutionsKind kind,
            string? id = default,
            global::LangSmith.GetSessionsResolutionsEnvironment? environment = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}