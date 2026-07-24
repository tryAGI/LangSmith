
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum QueryPublicSharedTraceRunsRequestBodySelect
    {
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
        InputsPreview,
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
        Metadata,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        OutputsPreview,
        /// <summary>
        /// 
        /// </summary>
        ParentRunId,
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
        RunType,
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
    public static class QueryPublicSharedTraceRunsRequestBodySelectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryPublicSharedTraceRunsRequestBodySelect value)
        {
            return value switch
            {
                QueryPublicSharedTraceRunsRequestBodySelect.CompletionCost => "COMPLETION_COST",
                QueryPublicSharedTraceRunsRequestBodySelect.CompletionCostDetails => "COMPLETION_COST_DETAILS",
                QueryPublicSharedTraceRunsRequestBodySelect.CompletionTokens => "COMPLETION_TOKENS",
                QueryPublicSharedTraceRunsRequestBodySelect.CompletionTokenDetails => "COMPLETION_TOKEN_DETAILS",
                QueryPublicSharedTraceRunsRequestBodySelect.DottedOrder => "DOTTED_ORDER",
                QueryPublicSharedTraceRunsRequestBodySelect.EndTime => "END_TIME",
                QueryPublicSharedTraceRunsRequestBodySelect.Error => "ERROR",
                QueryPublicSharedTraceRunsRequestBodySelect.ErrorPreview => "ERROR_PREVIEW",
                QueryPublicSharedTraceRunsRequestBodySelect.Extra => "EXTRA",
                QueryPublicSharedTraceRunsRequestBodySelect.FeedbackStats => "FEEDBACK_STATS",
                QueryPublicSharedTraceRunsRequestBodySelect.FirstTokenTime => "FIRST_TOKEN_TIME",
                QueryPublicSharedTraceRunsRequestBodySelect.Id => "ID",
                QueryPublicSharedTraceRunsRequestBodySelect.InputsPreview => "INPUTS_PREVIEW",
                QueryPublicSharedTraceRunsRequestBodySelect.IsRoot => "IS_ROOT",
                QueryPublicSharedTraceRunsRequestBodySelect.LatencySeconds => "LATENCY_SECONDS",
                QueryPublicSharedTraceRunsRequestBodySelect.Metadata => "METADATA",
                QueryPublicSharedTraceRunsRequestBodySelect.Name => "NAME",
                QueryPublicSharedTraceRunsRequestBodySelect.OutputsPreview => "OUTPUTS_PREVIEW",
                QueryPublicSharedTraceRunsRequestBodySelect.ParentRunId => "PARENT_RUN_ID",
                QueryPublicSharedTraceRunsRequestBodySelect.ParentRunIds => "PARENT_RUN_IDS",
                QueryPublicSharedTraceRunsRequestBodySelect.PriceModelId => "PRICE_MODEL_ID",
                QueryPublicSharedTraceRunsRequestBodySelect.ProjectId => "PROJECT_ID",
                QueryPublicSharedTraceRunsRequestBodySelect.PromptCost => "PROMPT_COST",
                QueryPublicSharedTraceRunsRequestBodySelect.PromptCostDetails => "PROMPT_COST_DETAILS",
                QueryPublicSharedTraceRunsRequestBodySelect.PromptTokens => "PROMPT_TOKENS",
                QueryPublicSharedTraceRunsRequestBodySelect.PromptTokenDetails => "PROMPT_TOKEN_DETAILS",
                QueryPublicSharedTraceRunsRequestBodySelect.ReferenceDatasetId => "REFERENCE_DATASET_ID",
                QueryPublicSharedTraceRunsRequestBodySelect.RunType => "RUN_TYPE",
                QueryPublicSharedTraceRunsRequestBodySelect.StartTime => "START_TIME",
                QueryPublicSharedTraceRunsRequestBodySelect.Status => "STATUS",
                QueryPublicSharedTraceRunsRequestBodySelect.Tags => "TAGS",
                QueryPublicSharedTraceRunsRequestBodySelect.ThreadEvaluationTime => "THREAD_EVALUATION_TIME",
                QueryPublicSharedTraceRunsRequestBodySelect.ThreadId => "THREAD_ID",
                QueryPublicSharedTraceRunsRequestBodySelect.TotalCost => "TOTAL_COST",
                QueryPublicSharedTraceRunsRequestBodySelect.TotalTokens => "TOTAL_TOKENS",
                QueryPublicSharedTraceRunsRequestBodySelect.TraceId => "TRACE_ID",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryPublicSharedTraceRunsRequestBodySelect? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETION_COST" => QueryPublicSharedTraceRunsRequestBodySelect.CompletionCost,
                "COMPLETION_COST_DETAILS" => QueryPublicSharedTraceRunsRequestBodySelect.CompletionCostDetails,
                "COMPLETION_TOKENS" => QueryPublicSharedTraceRunsRequestBodySelect.CompletionTokens,
                "COMPLETION_TOKEN_DETAILS" => QueryPublicSharedTraceRunsRequestBodySelect.CompletionTokenDetails,
                "DOTTED_ORDER" => QueryPublicSharedTraceRunsRequestBodySelect.DottedOrder,
                "END_TIME" => QueryPublicSharedTraceRunsRequestBodySelect.EndTime,
                "ERROR" => QueryPublicSharedTraceRunsRequestBodySelect.Error,
                "ERROR_PREVIEW" => QueryPublicSharedTraceRunsRequestBodySelect.ErrorPreview,
                "EXTRA" => QueryPublicSharedTraceRunsRequestBodySelect.Extra,
                "FEEDBACK_STATS" => QueryPublicSharedTraceRunsRequestBodySelect.FeedbackStats,
                "FIRST_TOKEN_TIME" => QueryPublicSharedTraceRunsRequestBodySelect.FirstTokenTime,
                "ID" => QueryPublicSharedTraceRunsRequestBodySelect.Id,
                "INPUTS_PREVIEW" => QueryPublicSharedTraceRunsRequestBodySelect.InputsPreview,
                "IS_ROOT" => QueryPublicSharedTraceRunsRequestBodySelect.IsRoot,
                "LATENCY_SECONDS" => QueryPublicSharedTraceRunsRequestBodySelect.LatencySeconds,
                "METADATA" => QueryPublicSharedTraceRunsRequestBodySelect.Metadata,
                "NAME" => QueryPublicSharedTraceRunsRequestBodySelect.Name,
                "OUTPUTS_PREVIEW" => QueryPublicSharedTraceRunsRequestBodySelect.OutputsPreview,
                "PARENT_RUN_ID" => QueryPublicSharedTraceRunsRequestBodySelect.ParentRunId,
                "PARENT_RUN_IDS" => QueryPublicSharedTraceRunsRequestBodySelect.ParentRunIds,
                "PRICE_MODEL_ID" => QueryPublicSharedTraceRunsRequestBodySelect.PriceModelId,
                "PROJECT_ID" => QueryPublicSharedTraceRunsRequestBodySelect.ProjectId,
                "PROMPT_COST" => QueryPublicSharedTraceRunsRequestBodySelect.PromptCost,
                "PROMPT_COST_DETAILS" => QueryPublicSharedTraceRunsRequestBodySelect.PromptCostDetails,
                "PROMPT_TOKENS" => QueryPublicSharedTraceRunsRequestBodySelect.PromptTokens,
                "PROMPT_TOKEN_DETAILS" => QueryPublicSharedTraceRunsRequestBodySelect.PromptTokenDetails,
                "REFERENCE_DATASET_ID" => QueryPublicSharedTraceRunsRequestBodySelect.ReferenceDatasetId,
                "RUN_TYPE" => QueryPublicSharedTraceRunsRequestBodySelect.RunType,
                "START_TIME" => QueryPublicSharedTraceRunsRequestBodySelect.StartTime,
                "STATUS" => QueryPublicSharedTraceRunsRequestBodySelect.Status,
                "TAGS" => QueryPublicSharedTraceRunsRequestBodySelect.Tags,
                "THREAD_EVALUATION_TIME" => QueryPublicSharedTraceRunsRequestBodySelect.ThreadEvaluationTime,
                "THREAD_ID" => QueryPublicSharedTraceRunsRequestBodySelect.ThreadId,
                "TOTAL_COST" => QueryPublicSharedTraceRunsRequestBodySelect.TotalCost,
                "TOTAL_TOKENS" => QueryPublicSharedTraceRunsRequestBodySelect.TotalTokens,
                "TRACE_ID" => QueryPublicSharedTraceRunsRequestBodySelect.TraceId,
                _ => null,
            };
        }
    }
}