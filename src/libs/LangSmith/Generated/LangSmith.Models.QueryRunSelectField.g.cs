
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum QueryRunSelectField
    {
        /// <summary>
        /// 
        /// </summary>
        RunSelectAppPath,
        /// <summary>
        /// 
        /// </summary>
        RunSelectAttachments,
        /// <summary>
        /// 
        /// </summary>
        RunSelectCompletionCost,
        /// <summary>
        /// 
        /// </summary>
        RunSelectCompletionCostDetails,
        /// <summary>
        /// 
        /// </summary>
        RunSelectCompletionTokens,
        /// <summary>
        /// 
        /// </summary>
        RunSelectCompletionTokenDetails,
        /// <summary>
        /// 
        /// </summary>
        RunSelectDottedOrder,
        /// <summary>
        /// 
        /// </summary>
        RunSelectEndTime,
        /// <summary>
        /// 
        /// </summary>
        RunSelectError,
        /// <summary>
        /// 
        /// </summary>
        RunSelectErrorPreview,
        /// <summary>
        /// 
        /// </summary>
        RunSelectEvents,
        /// <summary>
        /// 
        /// </summary>
        RunSelectExtra,
        /// <summary>
        /// 
        /// </summary>
        RunSelectFeedbackStats,
        /// <summary>
        /// 
        /// </summary>
        RunSelectFirstTokenTime,
        /// <summary>
        /// 
        /// </summary>
        RunSelectID,
        /// <summary>
        /// 
        /// </summary>
        RunSelectInputs,
        /// <summary>
        /// 
        /// </summary>
        RunSelectInputsPreview,
        /// <summary>
        /// 
        /// </summary>
        RunSelectIsInDataset,
        /// <summary>
        /// 
        /// </summary>
        RunSelectIsRoot,
        /// <summary>
        /// 
        /// </summary>
        RunSelectLatencySeconds,
        /// <summary>
        /// 
        /// </summary>
        RunSelectManifest,
        /// <summary>
        /// 
        /// </summary>
        RunSelectMetadata,
        /// <summary>
        /// 
        /// </summary>
        RunSelectName,
        /// <summary>
        /// 
        /// </summary>
        RunSelectOutputs,
        /// <summary>
        /// 
        /// </summary>
        RunSelectOutputsPreview,
        /// <summary>
        /// 
        /// </summary>
        RunSelectParentRunIDs,
        /// <summary>
        /// 
        /// </summary>
        RunSelectPriceModelID,
        /// <summary>
        /// 
        /// </summary>
        RunSelectProjectID,
        /// <summary>
        /// 
        /// </summary>
        RunSelectPromptCost,
        /// <summary>
        /// 
        /// </summary>
        RunSelectPromptCostDetails,
        /// <summary>
        /// 
        /// </summary>
        RunSelectPromptTokens,
        /// <summary>
        /// 
        /// </summary>
        RunSelectPromptTokenDetails,
        /// <summary>
        /// 
        /// </summary>
        RunSelectReferenceDatasetID,
        /// <summary>
        /// 
        /// </summary>
        RunSelectReferenceExampleID,
        /// <summary>
        /// 
        /// </summary>
        RunSelectRunType,
        /// <summary>
        /// 
        /// </summary>
        RunSelectShareURL,
        /// <summary>
        /// 
        /// </summary>
        RunSelectStartTime,
        /// <summary>
        /// 
        /// </summary>
        RunSelectStatus,
        /// <summary>
        /// 
        /// </summary>
        RunSelectTags,
        /// <summary>
        /// 
        /// </summary>
        RunSelectThreadEvaluationTime,
        /// <summary>
        /// 
        /// </summary>
        RunSelectThreadID,
        /// <summary>
        /// 
        /// </summary>
        RunSelectTotalCost,
        /// <summary>
        /// 
        /// </summary>
        RunSelectTotalTokens,
        /// <summary>
        /// 
        /// </summary>
        RunSelectTraceID,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryRunSelectFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryRunSelectField value)
        {
            return value switch
            {
                QueryRunSelectField.RunSelectAppPath => "APP_PATH",
                QueryRunSelectField.RunSelectAttachments => "ATTACHMENTS",
                QueryRunSelectField.RunSelectCompletionCost => "COMPLETION_COST",
                QueryRunSelectField.RunSelectCompletionCostDetails => "COMPLETION_COST_DETAILS",
                QueryRunSelectField.RunSelectCompletionTokens => "COMPLETION_TOKENS",
                QueryRunSelectField.RunSelectCompletionTokenDetails => "COMPLETION_TOKEN_DETAILS",
                QueryRunSelectField.RunSelectDottedOrder => "DOTTED_ORDER",
                QueryRunSelectField.RunSelectEndTime => "END_TIME",
                QueryRunSelectField.RunSelectError => "ERROR",
                QueryRunSelectField.RunSelectErrorPreview => "ERROR_PREVIEW",
                QueryRunSelectField.RunSelectEvents => "EVENTS",
                QueryRunSelectField.RunSelectExtra => "EXTRA",
                QueryRunSelectField.RunSelectFeedbackStats => "FEEDBACK_STATS",
                QueryRunSelectField.RunSelectFirstTokenTime => "FIRST_TOKEN_TIME",
                QueryRunSelectField.RunSelectID => "ID",
                QueryRunSelectField.RunSelectInputs => "INPUTS",
                QueryRunSelectField.RunSelectInputsPreview => "INPUTS_PREVIEW",
                QueryRunSelectField.RunSelectIsInDataset => "IS_IN_DATASET",
                QueryRunSelectField.RunSelectIsRoot => "IS_ROOT",
                QueryRunSelectField.RunSelectLatencySeconds => "LATENCY_SECONDS",
                QueryRunSelectField.RunSelectManifest => "MANIFEST",
                QueryRunSelectField.RunSelectMetadata => "METADATA",
                QueryRunSelectField.RunSelectName => "NAME",
                QueryRunSelectField.RunSelectOutputs => "OUTPUTS",
                QueryRunSelectField.RunSelectOutputsPreview => "OUTPUTS_PREVIEW",
                QueryRunSelectField.RunSelectParentRunIDs => "PARENT_RUN_IDS",
                QueryRunSelectField.RunSelectPriceModelID => "PRICE_MODEL_ID",
                QueryRunSelectField.RunSelectProjectID => "PROJECT_ID",
                QueryRunSelectField.RunSelectPromptCost => "PROMPT_COST",
                QueryRunSelectField.RunSelectPromptCostDetails => "PROMPT_COST_DETAILS",
                QueryRunSelectField.RunSelectPromptTokens => "PROMPT_TOKENS",
                QueryRunSelectField.RunSelectPromptTokenDetails => "PROMPT_TOKEN_DETAILS",
                QueryRunSelectField.RunSelectReferenceDatasetID => "REFERENCE_DATASET_ID",
                QueryRunSelectField.RunSelectReferenceExampleID => "REFERENCE_EXAMPLE_ID",
                QueryRunSelectField.RunSelectRunType => "RUN_TYPE",
                QueryRunSelectField.RunSelectShareURL => "SHARE_URL",
                QueryRunSelectField.RunSelectStartTime => "START_TIME",
                QueryRunSelectField.RunSelectStatus => "STATUS",
                QueryRunSelectField.RunSelectTags => "TAGS",
                QueryRunSelectField.RunSelectThreadEvaluationTime => "THREAD_EVALUATION_TIME",
                QueryRunSelectField.RunSelectThreadID => "THREAD_ID",
                QueryRunSelectField.RunSelectTotalCost => "TOTAL_COST",
                QueryRunSelectField.RunSelectTotalTokens => "TOTAL_TOKENS",
                QueryRunSelectField.RunSelectTraceID => "TRACE_ID",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryRunSelectField? ToEnum(string value)
        {
            return value switch
            {
                "APP_PATH" => QueryRunSelectField.RunSelectAppPath,
                "ATTACHMENTS" => QueryRunSelectField.RunSelectAttachments,
                "COMPLETION_COST" => QueryRunSelectField.RunSelectCompletionCost,
                "COMPLETION_COST_DETAILS" => QueryRunSelectField.RunSelectCompletionCostDetails,
                "COMPLETION_TOKENS" => QueryRunSelectField.RunSelectCompletionTokens,
                "COMPLETION_TOKEN_DETAILS" => QueryRunSelectField.RunSelectCompletionTokenDetails,
                "DOTTED_ORDER" => QueryRunSelectField.RunSelectDottedOrder,
                "END_TIME" => QueryRunSelectField.RunSelectEndTime,
                "ERROR" => QueryRunSelectField.RunSelectError,
                "ERROR_PREVIEW" => QueryRunSelectField.RunSelectErrorPreview,
                "EVENTS" => QueryRunSelectField.RunSelectEvents,
                "EXTRA" => QueryRunSelectField.RunSelectExtra,
                "FEEDBACK_STATS" => QueryRunSelectField.RunSelectFeedbackStats,
                "FIRST_TOKEN_TIME" => QueryRunSelectField.RunSelectFirstTokenTime,
                "ID" => QueryRunSelectField.RunSelectID,
                "INPUTS" => QueryRunSelectField.RunSelectInputs,
                "INPUTS_PREVIEW" => QueryRunSelectField.RunSelectInputsPreview,
                "IS_IN_DATASET" => QueryRunSelectField.RunSelectIsInDataset,
                "IS_ROOT" => QueryRunSelectField.RunSelectIsRoot,
                "LATENCY_SECONDS" => QueryRunSelectField.RunSelectLatencySeconds,
                "MANIFEST" => QueryRunSelectField.RunSelectManifest,
                "METADATA" => QueryRunSelectField.RunSelectMetadata,
                "NAME" => QueryRunSelectField.RunSelectName,
                "OUTPUTS" => QueryRunSelectField.RunSelectOutputs,
                "OUTPUTS_PREVIEW" => QueryRunSelectField.RunSelectOutputsPreview,
                "PARENT_RUN_IDS" => QueryRunSelectField.RunSelectParentRunIDs,
                "PRICE_MODEL_ID" => QueryRunSelectField.RunSelectPriceModelID,
                "PROJECT_ID" => QueryRunSelectField.RunSelectProjectID,
                "PROMPT_COST" => QueryRunSelectField.RunSelectPromptCost,
                "PROMPT_COST_DETAILS" => QueryRunSelectField.RunSelectPromptCostDetails,
                "PROMPT_TOKENS" => QueryRunSelectField.RunSelectPromptTokens,
                "PROMPT_TOKEN_DETAILS" => QueryRunSelectField.RunSelectPromptTokenDetails,
                "REFERENCE_DATASET_ID" => QueryRunSelectField.RunSelectReferenceDatasetID,
                "REFERENCE_EXAMPLE_ID" => QueryRunSelectField.RunSelectReferenceExampleID,
                "RUN_TYPE" => QueryRunSelectField.RunSelectRunType,
                "SHARE_URL" => QueryRunSelectField.RunSelectShareURL,
                "START_TIME" => QueryRunSelectField.RunSelectStartTime,
                "STATUS" => QueryRunSelectField.RunSelectStatus,
                "TAGS" => QueryRunSelectField.RunSelectTags,
                "THREAD_EVALUATION_TIME" => QueryRunSelectField.RunSelectThreadEvaluationTime,
                "THREAD_ID" => QueryRunSelectField.RunSelectThreadID,
                "TOTAL_COST" => QueryRunSelectField.RunSelectTotalCost,
                "TOTAL_TOKENS" => QueryRunSelectField.RunSelectTotalTokens,
                "TRACE_ID" => QueryRunSelectField.RunSelectTraceID,
                _ => null,
            };
        }
    }
}