#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Update a warm pool<br/>
        /// Update a warm pool's name or replica count
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesPoolResponse> UpdateAWarmPoolAsync(

            global::LangSmith.SandboxesUpdatePoolPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a warm pool<br/>
        /// Update a warm pool's name or replica count
        /// </summary>
        /// <param name="name"></param>
        /// <param name="replicas"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesPoolResponse> UpdateAWarmPoolAsync(
            string? name = default,
            int? replicas = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}