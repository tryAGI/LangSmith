
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRunsSelect
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
    public static class GetRunsSelectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRunsSelect value)
        {
            return value switch
            {
                GetRunsSelect.AppPath => "APP_PATH",
                GetRunsSelect.Attachments => "ATTACHMENTS",
                GetRunsSelect.CompletionCost => "COMPLETION_COST",
                GetRunsSelect.CompletionCostDetails => "COMPLETION_COST_DETAILS",
                GetRunsSelect.CompletionTokens => "COMPLETION_TOKENS",
                GetRunsSelect.CompletionTokenDetails => "COMPLETION_TOKEN_DETAILS",
                GetRunsSelect.DottedOrder => "DOTTED_ORDER",
                GetRunsSelect.EndTime => "END_TIME",
                GetRunsSelect.Error => "ERROR",
                GetRunsSelect.ErrorPreview => "ERROR_PREVIEW",
                GetRunsSelect.Events => "EVENTS",
                GetRunsSelect.Extra => "EXTRA",
                GetRunsSelect.FeedbackStats => "FEEDBACK_STATS",
                GetRunsSelect.FirstTokenTime => "FIRST_TOKEN_TIME",
                GetRunsSelect.Id => "ID",
                GetRunsSelect.Inputs => "INPUTS",
                GetRunsSelect.InputsPreview => "INPUTS_PREVIEW",
                GetRunsSelect.IsInDataset => "IS_IN_DATASET",
                GetRunsSelect.IsRoot => "IS_ROOT",
                GetRunsSelect.LatencySeconds => "LATENCY_SECONDS",
                GetRunsSelect.Manifest => "MANIFEST",
                GetRunsSelect.Metadata => "METADATA",
                GetRunsSelect.Name => "NAME",
                GetRunsSelect.Outputs => "OUTPUTS",
                GetRunsSelect.OutputsPreview => "OUTPUTS_PREVIEW",
                GetRunsSelect.ParentRunIds => "PARENT_RUN_IDS",
                GetRunsSelect.PriceModelId => "PRICE_MODEL_ID",
                GetRunsSelect.ProjectId => "PROJECT_ID",
                GetRunsSelect.PromptCost => "PROMPT_COST",
                GetRunsSelect.PromptCostDetails => "PROMPT_COST_DETAILS",
                GetRunsSelect.PromptTokens => "PROMPT_TOKENS",
                GetRunsSelect.PromptTokenDetails => "PROMPT_TOKEN_DETAILS",
                GetRunsSelect.ReferenceDatasetId => "REFERENCE_DATASET_ID",
                GetRunsSelect.ReferenceExampleId => "REFERENCE_EXAMPLE_ID",
                GetRunsSelect.RunType => "RUN_TYPE",
                GetRunsSelect.ShareUrl => "SHARE_URL",
                GetRunsSelect.StartTime => "START_TIME",
                GetRunsSelect.Status => "STATUS",
                GetRunsSelect.Tags => "TAGS",
                GetRunsSelect.ThreadEvaluationTime => "THREAD_EVALUATION_TIME",
                GetRunsSelect.ThreadId => "THREAD_ID",
                GetRunsSelect.TotalCost => "TOTAL_COST",
                GetRunsSelect.TotalTokens => "TOTAL_TOKENS",
                GetRunsSelect.TraceId => "TRACE_ID",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRunsSelect? ToEnum(string value)
        {
            return value switch
            {
                "APP_PATH" => GetRunsSelect.AppPath,
                "ATTACHMENTS" => GetRunsSelect.Attachments,
                "COMPLETION_COST" => GetRunsSelect.CompletionCost,
                "COMPLETION_COST_DETAILS" => GetRunsSelect.CompletionCostDetails,
                "COMPLETION_TOKENS" => GetRunsSelect.CompletionTokens,
                "COMPLETION_TOKEN_DETAILS" => GetRunsSelect.CompletionTokenDetails,
                "DOTTED_ORDER" => GetRunsSelect.DottedOrder,
                "END_TIME" => GetRunsSelect.EndTime,
                "ERROR" => GetRunsSelect.Error,
                "ERROR_PREVIEW" => GetRunsSelect.ErrorPreview,
                "EVENTS" => GetRunsSelect.Events,
                "EXTRA" => GetRunsSelect.Extra,
                "FEEDBACK_STATS" => GetRunsSelect.FeedbackStats,
                "FIRST_TOKEN_TIME" => GetRunsSelect.FirstTokenTime,
                "ID" => GetRunsSelect.Id,
                "INPUTS" => GetRunsSelect.Inputs,
                "INPUTS_PREVIEW" => GetRunsSelect.InputsPreview,
                "IS_IN_DATASET" => GetRunsSelect.IsInDataset,
                "IS_ROOT" => GetRunsSelect.IsRoot,
                "LATENCY_SECONDS" => GetRunsSelect.LatencySeconds,
                "MANIFEST" => GetRunsSelect.Manifest,
                "METADATA" => GetRunsSelect.Metadata,
                "NAME" => GetRunsSelect.Name,
                "OUTPUTS" => GetRunsSelect.Outputs,
                "OUTPUTS_PREVIEW" => GetRunsSelect.OutputsPreview,
                "PARENT_RUN_IDS" => GetRunsSelect.ParentRunIds,
                "PRICE_MODEL_ID" => GetRunsSelect.PriceModelId,
                "PROJECT_ID" => GetRunsSelect.ProjectId,
                "PROMPT_COST" => GetRunsSelect.PromptCost,
                "PROMPT_COST_DETAILS" => GetRunsSelect.PromptCostDetails,
                "PROMPT_TOKENS" => GetRunsSelect.PromptTokens,
                "PROMPT_TOKEN_DETAILS" => GetRunsSelect.PromptTokenDetails,
                "REFERENCE_DATASET_ID" => GetRunsSelect.ReferenceDatasetId,
                "REFERENCE_EXAMPLE_ID" => GetRunsSelect.ReferenceExampleId,
                "RUN_TYPE" => GetRunsSelect.RunType,
                "SHARE_URL" => GetRunsSelect.ShareUrl,
                "START_TIME" => GetRunsSelect.StartTime,
                "STATUS" => GetRunsSelect.Status,
                "TAGS" => GetRunsSelect.Tags,
                "THREAD_EVALUATION_TIME" => GetRunsSelect.ThreadEvaluationTime,
                "THREAD_ID" => GetRunsSelect.ThreadId,
                "TOTAL_COST" => GetRunsSelect.TotalCost,
                "TOTAL_TOKENS" => GetRunsSelect.TotalTokens,
                "TRACE_ID" => GetRunsSelect.TraceId,
                _ => null,
            };
        }
    }
}