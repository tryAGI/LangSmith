#nullable enable

namespace LangSmith
{
    public partial interface IPlaygroundClient
    {
        /// <summary>
        /// Dataset Handler
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DatasetHandlerApiV1PlaygroundDatasetPostResponse> DatasetHandlerAsync(
            global::LangSmith.PlaygroundRunOverDatasetRequestSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Dataset Handler
        /// </summary>
        /// <param name="manifest"></param>
        /// <param name="secrets"></param>
        /// <param name="runId"></param>
        /// <param name="repoId"></param>
        /// <param name="tools"></param>
        /// <param name="options">
        /// Configuration for a Runnable.
        /// </param>
        /// <param name="projectName"></param>
        /// <param name="datasetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DatasetHandlerApiV1PlaygroundDatasetPostResponse> DatasetHandlerAsync(
            global::LangSmith.PlaygroundRunOverDatasetRequestSchemaManifest manifest,
            global::LangSmith.PlaygroundRunOverDatasetRequestSchemaSecrets secrets,
            global::LangSmith.RunnableConfig options,
            global::System.Guid datasetId,
            global::LangSmith.AnyOf<string, object>? runId = default,
            global::LangSmith.AnyOf<string, object>? repoId = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.PlaygroundRunOverDatasetRequestSchemaToolsVariant1Item>, object>? tools = default,
            global::LangSmith.AnyOf<string, object>? projectName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}