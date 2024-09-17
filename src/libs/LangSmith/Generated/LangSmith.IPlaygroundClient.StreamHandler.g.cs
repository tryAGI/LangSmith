#nullable enable

namespace LangSmith
{
    public partial interface IPlaygroundClient
    {
        /// <summary>
        /// Stream Handler
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.StreamHandlerApiV1PlaygroundStreamPostResponse> StreamHandlerAsync(
            global::LangSmith.PlaygroundStreamRequestSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Stream Handler
        /// </summary>
        /// <param name="manifest"></param>
        /// <param name="secrets"></param>
        /// <param name="runId"></param>
        /// <param name="repoId"></param>
        /// <param name="tools"></param>
        /// <param name="options">
        /// Configuration for a Runnable.
        /// </param>
        /// <param name="input"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.StreamHandlerApiV1PlaygroundStreamPostResponse> StreamHandlerAsync(
            global::LangSmith.PlaygroundStreamRequestSchemaManifest manifest,
            global::LangSmith.PlaygroundStreamRequestSchemaSecrets secrets,
            global::LangSmith.RunnableConfig options,
            global::LangSmith.PlaygroundStreamRequestSchemaInput input,
            global::LangSmith.AnyOf<string, object>? runId = default,
            global::LangSmith.AnyOf<string, object>? repoId = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.PlaygroundStreamRequestSchemaToolsVariant1Item>, object>? tools = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}