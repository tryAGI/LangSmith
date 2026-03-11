
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlaygroundRunOverDatasetBatchRequestSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public object Manifest { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.Dictionary<string, string> Secrets { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo_id")]
        public string? RepoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<object>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        public string? ToolChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
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
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::LangSmith.RunnableConfig Options { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ProjectName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo_handle")]
        public string? RepoHandle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public string? Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit")]
        public string? Commit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator_rules")]
        public global::System.Collections.Generic.IList<global::System.Guid>? EvaluatorRules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests_per_second")]
        public int? RequestsPerSecond { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_or_fallback_to_workspace_secrets")]
        public bool? UseOrFallbackToWorkspaceSecrets { get; set; }

        /// <summary>
        /// Default Value: langsmith_ui
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_context")]
        public global::LangSmith.RunnerContextEnum? RunnerContext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid DatasetId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_splits")]
        public global::System.Collections.Generic.IList<string>? DatasetSplits { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repetitions")]
        public int? Repetitions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_size")]
        public int? BatchSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundRunOverDatasetBatchRequestSchema" /> class.
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
        /// <param name="runnerContext">
        /// Default Value: langsmith_ui
        /// </param>
        /// <param name="datasetId"></param>
        /// <param name="datasetSplits"></param>
        /// <param name="repetitions">
        /// Default Value: 1
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="batchSize"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaygroundRunOverDatasetBatchRequestSchema(
            object manifest,
            global::System.Collections.Generic.Dictionary<string, string> secrets,
            global::LangSmith.RunnableConfig options,
            string projectName,
            global::System.Guid datasetId,
            string? runId,
            string? repoId,
            global::System.Collections.Generic.IList<object>? tools,
            string? toolChoice,
            bool? parallelToolCalls,
            string? repoHandle,
            string? owner,
            string? commit,
            global::System.Collections.Generic.IList<global::System.Guid>? evaluatorRules,
            int? requestsPerSecond,
            bool? useOrFallbackToWorkspaceSecrets,
            global::LangSmith.RunnerContextEnum? runnerContext,
            global::System.Collections.Generic.IList<string>? datasetSplits,
            int? repetitions,
            object? metadata,
            int? batchSize)
        {
            this.Manifest = manifest ?? throw new global::System.ArgumentNullException(nameof(manifest));
            this.Secrets = secrets ?? throw new global::System.ArgumentNullException(nameof(secrets));
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.DatasetId = datasetId;
            this.RunId = runId;
            this.RepoId = repoId;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.ParallelToolCalls = parallelToolCalls;
            this.RepoHandle = repoHandle;
            this.Owner = owner;
            this.Commit = commit;
            this.EvaluatorRules = evaluatorRules;
            this.RequestsPerSecond = requestsPerSecond;
            this.UseOrFallbackToWorkspaceSecrets = useOrFallbackToWorkspaceSecrets;
            this.RunnerContext = runnerContext;
            this.DatasetSplits = datasetSplits;
            this.Repetitions = repetitions;
            this.Metadata = metadata;
            this.BatchSize = batchSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundRunOverDatasetBatchRequestSchema" /> class.
        /// </summary>
        public PlaygroundRunOverDatasetBatchRequestSchema()
        {
        }
    }
}