#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Stream Dataset Handler
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StreamDatasetHandlerAsync(
            global::LangSmith.PlaygroundRunOverDatasetRequestSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Stream Dataset Handler
        /// </summary>
        /// <param name="manifest"></param>
        /// <param name="secrets"></param>
        /// <param name="runId"></param>
        /// <param name="repoId"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="options">
        /// Configuration for a `Runnable`.<br/>
        /// !!! note Custom values<br/>
        ///     The `TypedDict` has `total=False` set intentionally to:<br/>
        ///     - Allow partial configs to be created and merged together via `merge_configs`<br/>
        ///     - Support config propagation from parent to child runnables via<br/>
        ///         `var_child_runnable_config` (a `ContextVar` that automatically passes<br/>
        ///         config down the call stack without explicit parameter passing), where<br/>
        ///         configs are merged rather than replaced<br/>
        ///     !!! example<br/>
        ///         ```python<br/>
        ///         # Parent sets tags<br/>
        ///         chain.invoke(input, config={"tags": ["parent"]})<br/>
        ///         # Child automatically inherits and can add:<br/>
        ///         # ensure_config({"tags": ["child"]}) -&gt; {"tags": ["parent", "child"]}<br/>
        ///         ```
        /// </param>
        /// <param name="projectName"></param>
        /// <param name="repoHandle"></param>
        /// <param name="owner"></param>
        /// <param name="commit"></param>
        /// <param name="evaluatorRules"></param>
        /// <param name="requestsPerSecond"></param>
        /// <param name="useOrFallbackToWorkspaceSecrets">
        /// Default Value: false
        /// </param>
        /// <param name="runnerContext"></param>
        /// <param name="datasetId"></param>
        /// <param name="datasetSplits"></param>
        /// <param name="repetitions">
        /// Default Value: 1
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StreamDatasetHandlerAsync(
            object manifest,
            global::System.Collections.Generic.Dictionary<string, string> secrets,
            global::LangSmith.RunnableConfig options,
            string projectName,
            global::System.Guid datasetId,
            string? runId = default,
            string? repoId = default,
            global::System.Collections.Generic.IList<object>? tools = default,
            string? toolChoice = default,
            bool? parallelToolCalls = default,
            string? repoHandle = default,
            string? owner = default,
            string? commit = default,
            global::System.Collections.Generic.IList<global::System.Guid>? evaluatorRules = default,
            int? requestsPerSecond = default,
            bool? useOrFallbackToWorkspaceSecrets = default,
            global::LangSmith.RunnerContextEnum? runnerContext = default,
            global::System.Collections.Generic.IList<string>? datasetSplits = default,
            int? repetitions = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}