
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTracesRunsSelect
    {
        /// <summary>
        /// 
        /// </summary>
        AppPath,
        /// <summary>
        /// 
        /// </summary>
        Attachments,
        /// <summary>
        /// 
        /// </summary>
        CompletionCost,
        /// <summary>
        /// 
        /// </summary>
        CompletionCostDetails,
        /// <summary>
        /// 
        /// </summary>
        CompletionTokens,
        /// <summary>
        /// 
        /// </summary>
        CompletionTokenDetails,
        /// <summary>
        /// 
        /// </summary>
        DottedOrder,
        /// <summary>
        /// 
        /// </summary>
        EndTime,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        ErrorPreview,
        /// <summary>
        /// 
        /// </summary>
        Events,
        /// <summary>
        /// 
        /// </summary>
        Extra,
        /// <summary>
        /// 
        /// </summary>
        FeedbackStats,
        /// <summary>
        /// 
        /// </summary>
        FirstTokenTime,
        /// <summary>
        /// 
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        Inputs,
        /// <summary>
        /// 
        /// </summary>
        InputsPreview,
        /// <summary>
        /// 
        /// </summary>
        IsInDataset,
        /// <summary>
        /// 
        /// </summary>
        IsRoot,
        /// <summary>
        /// 
        /// </summary>
        LastQueuedAt,
        /// <summary>
        /// 
        /// </summary>
        LatencySeconds,
        /// <summary>
        /// 
        /// </summary>
        Manifest,
        /// <summary>
        /// 
        /// </summary>
        Metadata,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        Outputs,
        /// <summary>
        /// 
        /// </summary>
        OutputsPreview,
        /// <summary>
        /// 
        /// </summary>
        ParentRunIds,
        /// <summary>
        /// 
        /// </summary>
        PriceModelId,
        /// <summary>
        /// 
        /// </summary>
        ProjectId,
        /// <summary>
        /// 
        /// </summary>
        PromptCost,
        /// <summary>
        /// 
        /// </summary>
        PromptCostDetails,
        /// <summary>
        /// 
        /// </summary>
        PromptTokens,
        /// <summary>
        /// 
        /// </summary>
        PromptTokenDetails,
        /// <summary>
        /// 
        /// </summary>
        ReferenceDatasetId,
        /// <summary>
        /// 
        /// </summary>
        ReferenceExampleId,
        /// <summary>
        /// 
        /// </summary>
        RunType,
        /// <summary>
        /// 
        /// </summary>
        ShareUrl,
        /// <summary>
        /// 
        /// </summary>
        StartTime,
        /// <summary>
        /// 
        /// </summary>
        Status,
        /// <summary>
        /// 
        /// </summary>
        Tags,
        /// <summary>
        /// 
        /// </summary>
        ThreadEvaluationTime,
        /// <summary>
        /// 
        /// </summary>
        ThreadId,
        /// <summary>
        /// 
        /// </summary>
        TotalCost,
        /// <summary>
        /// 
        /// </summary>
        TotalTokens,
        /// <summary>
        /// 
        /// </summary>
        TraceId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTracesRunsSelectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTracesRunsSelect value)
        {
            return value switch
            {
                GetTracesRunsSelect.AppPath => "APP_PATH",
                GetTracesRunsSelect.Attachments => "ATTACHMENTS",
                GetTracesRunsSelect.CompletionCost => "COMPLETION_COST",
                GetTracesRunsSelect.CompletionCostDetails => "COMPLETION_COST_DETAILS",
                GetTracesRunsSelect.CompletionTokens => "COMPLETION_TOKENS",
                GetTracesRunsSelect.CompletionTokenDetails => "COMPLETION_TOKEN_DETAILS",
                GetTracesRunsSelect.DottedOrder => "DOTTED_ORDER",
                GetTracesRunsSelect.EndTime => "END_TIME",
                GetTracesRunsSelect.Error => "ERROR",
                GetTracesRunsSelect.ErrorPreview => "ERROR_PREVIEW",
                GetTracesRunsSelect.Events => "EVENTS",
                GetTracesRunsSelect.Extra => "EXTRA",
                GetTracesRunsSelect.FeedbackStats => "FEEDBACK_STATS",
                GetTracesRunsSelect.FirstTokenTime => "FIRST_TOKEN_TIME",
                GetTracesRunsSelect.Id => "ID",
                GetTracesRunsSelect.Inputs => "INPUTS",
                GetTracesRunsSelect.InputsPreview => "INPUTS_PREVIEW",
                GetTracesRunsSelect.IsInDataset => "IS_IN_DATASET",
                GetTracesRunsSelect.IsRoot => "IS_ROOT",
                GetTracesRunsSelect.LastQueuedAt => "LAST_QUEUED_AT",
                GetTracesRunsSelect.LatencySeconds => "LATENCY_SECONDS",
                GetTracesRunsSelect.Manifest => "MANIFEST",
                GetTracesRunsSelect.Metadata => "METADATA",
                GetTracesRunsSelect.Name => "NAME",
                GetTracesRunsSelect.Outputs => "OUTPUTS",
                GetTracesRunsSelect.OutputsPreview => "OUTPUTS_PREVIEW",
                GetTracesRunsSelect.ParentRunIds => "PARENT_RUN_IDS",
                GetTracesRunsSelect.PriceModelId => "PRICE_MODEL_ID",
                GetTracesRunsSelect.ProjectId => "PROJECT_ID",
                GetTracesRunsSelect.PromptCost => "PROMPT_COST",
                GetTracesRunsSelect.PromptCostDetails => "PROMPT_COST_DETAILS",
                GetTracesRunsSelect.PromptTokens => "PROMPT_TOKENS",
                GetTracesRunsSelect.PromptTokenDetails => "PROMPT_TOKEN_DETAILS",
                GetTracesRunsSelect.ReferenceDatasetId => "REFERENCE_DATASET_ID",
                GetTracesRunsSelect.ReferenceExampleId => "REFERENCE_EXAMPLE_ID",
                GetTracesRunsSelect.RunType => "RUN_TYPE",
                GetTracesRunsSelect.ShareUrl => "SHARE_URL",
                GetTracesRunsSelect.StartTime => "START_TIME",
                GetTracesRunsSelect.Status => "STATUS",
                GetTracesRunsSelect.Tags => "TAGS",
                GetTracesRunsSelect.ThreadEvaluationTime => "THREAD_EVALUATION_TIME",
                GetTracesRunsSelect.ThreadId => "THREAD_ID",
                GetTracesRunsSelect.TotalCost => "TOTAL_COST",
                GetTracesRunsSelect.TotalTokens => "TOTAL_TOKENS",
                GetTracesRunsSelect.TraceId => "TRACE_ID",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTracesRunsSelect? ToEnum(string value)
        {
            return value switch
            {
                "APP_PATH" => GetTracesRunsSelect.AppPath,
                "ATTACHMENTS" => GetTracesRunsSelect.Attachments,
                "COMPLETION_COST" => GetTracesRunsSelect.CompletionCost,
                "COMPLETION_COST_DETAILS" => GetTracesRunsSelect.CompletionCostDetails,
                "COMPLETION_TOKENS" => GetTracesRunsSelect.CompletionTokens,
                "COMPLETION_TOKEN_DETAILS" => GetTracesRunsSelect.CompletionTokenDetails,
                "DOTTED_ORDER" => GetTracesRunsSelect.DottedOrder,
                "END_TIME" => GetTracesRunsSelect.EndTime,
                "ERROR" => GetTracesRunsSelect.Error,
                "ERROR_PREVIEW" => GetTracesRunsSelect.ErrorPreview,
                "EVENTS" => GetTracesRunsSelect.Events,
                "EXTRA" => GetTracesRunsSelect.Extra,
                "FEEDBACK_STATS" => GetTracesRunsSelect.FeedbackStats,
                "FIRST_TOKEN_TIME" => GetTracesRunsSelect.FirstTokenTime,
                "ID" => GetTracesRunsSelect.Id,
                "INPUTS" => GetTracesRunsSelect.Inputs,
                "INPUTS_PREVIEW" => GetTracesRunsSelect.InputsPreview,
                "IS_IN_DATASET" => GetTracesRunsSelect.IsInDataset,
                "IS_ROOT" => GetTracesRunsSelect.IsRoot,
                "LAST_QUEUED_AT" => GetTracesRunsSelect.LastQueuedAt,
                "LATENCY_SECONDS" => GetTracesRunsSelect.LatencySeconds,
                "MANIFEST" => GetTracesRunsSelect.Manifest,
                "METADATA" => GetTracesRunsSelect.Metadata,
                "NAME" => GetTracesRunsSelect.Name,
                "OUTPUTS" => GetTracesRunsSelect.Outputs,
                "OUTPUTS_PREVIEW" => GetTracesRunsSelect.OutputsPreview,
                "PARENT_RUN_IDS" => GetTracesRunsSelect.ParentRunIds,
                "PRICE_MODEL_ID" => GetTracesRunsSelect.PriceModelId,
                "PROJECT_ID" => GetTracesRunsSelect.ProjectId,
                "PROMPT_COST" => GetTracesRunsSelect.PromptCost,
                "PROMPT_COST_DETAILS" => GetTracesRunsSelect.PromptCostDetails,
                "PROMPT_TOKENS" => GetTracesRunsSelect.PromptTokens,
                "PROMPT_TOKEN_DETAILS" => GetTracesRunsSelect.PromptTokenDetails,
                "REFERENCE_DATASET_ID" => GetTracesRunsSelect.ReferenceDatasetId,
                "REFERENCE_EXAMPLE_ID" => GetTracesRunsSelect.ReferenceExampleId,
                "RUN_TYPE" => GetTracesRunsSelect.RunType,
                "SHARE_URL" => GetTracesRunsSelect.ShareUrl,
                "START_TIME" => GetTracesRunsSelect.StartTime,
                "STATUS" => GetTracesRunsSelect.Status,
                "TAGS" => GetTracesRunsSelect.Tags,
                "THREAD_EVALUATION_TIME" => GetTracesRunsSelect.ThreadEvaluationTime,
                "THREAD_ID" => GetTracesRunsSelect.ThreadId,
                "TOTAL_COST" => GetTracesRunsSelect.TotalCost,
                "TOTAL_TOKENS" => GetTracesRunsSelect.TotalTokens,
                "TRACE_ID" => GetTracesRunsSelect.TraceId,
                _ => null,
            };
        }
    }
}