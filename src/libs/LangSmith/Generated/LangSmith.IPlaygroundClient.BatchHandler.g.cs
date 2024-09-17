#nullable enable

namespace LangSmith
{
    public partial interface IPlaygroundClient
    {
        /// <summary>
        /// Batch Handler
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.BatchHandlerApiV1PlaygroundBatchPostResponse> BatchHandlerAsync(
            global::LangSmith.PlaygroundBatchRequestSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Batch Handler
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
        global::System.Threading.Tasks.Task<global::LangSmith.BatchHandlerApiV1PlaygroundBatchPostResponse> BatchHandlerAsync(
            global::LangSmith.PlaygroundBatchRequestSchemaManifest manifest,
            global::LangSmith.PlaygroundBatchRequestSchemaSecrets secrets,
            global::LangSmith.RunnableConfig options,
            global::System.Collections.Generic.IList<global::LangSmith.PlaygroundBatchRequestSchemaInputItem> input,
            global::LangSmith.AnyOf<string, object>? runId = default,
            global::LangSmith.AnyOf<string, object>? repoId = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.PlaygroundBatchRequestSchemaToolsVariant1Item>, object>? tools = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}