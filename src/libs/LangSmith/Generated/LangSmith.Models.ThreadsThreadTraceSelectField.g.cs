
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum ThreadsThreadTraceSelectField
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadTraceSelectCompletionCost,
        /// <summary>
        /// 
        /// </summary>
        ThreadTraceSelectCompletionCostDetails,
        /// <summary>
        /// 
        /// </summary>
        ThreadTraceSelectCompletionTokens,
        /// <summary>
        /// 
        /// </summary>
        ThreadTraceSelectCompletionTokenDetails,
        /// <summary>
        /// 
        /// </summary>
        ThreadTraceSelectEndTime,
        /// <summary>
        /// 
        /// </summary>
        ThreadTraceSelectErrorPreview,
        /// <summary>
        /// 
        /// </summary>
        ThreadTraceSelectFirstTokenTime,
        /// <summary>
        /// 
        /// </summary>
        ThreadTraceSelectInputsPreview,
        /// <summary>
        /// 
        /// </summary>
        ThreadTraceSelectLatency,
        /// <summary>
        /// 
        /// </summary>
        ThreadTraceSelectName,
        /// <summary>
        /// 
        /// </summary>
        ThreadTraceSelectOp,
        /// <summary>
        /// 
        /// </summary>
        ThreadTraceSelectOutputsPreview,
        /// <summary>
        /// 
        /// </summary>
        ThreadTraceSelectPromptCost,
        /// <summary>
        /// 
        /// </summary>
        ThreadTraceSelectPromptCostDetails,
        /// <summary>
        /// 
        /// </summary>
        ThreadTraceSelectPromptTokens,
        /// <summary>
        /// 
        /// </summary>
        ThreadTraceSelectPromptTokenDetails,
        /// <summary>
        /// 
        /// </summary>
        ThreadTraceSelectStartTime,
        /// <summary>
        /// 
        /// </summary>
        ThreadTraceSelectThreadID,
        /// <summary>
        /// 
        /// </summary>
        ThreadTraceSelectTotalCost,
        /// <summary>
        /// 
        /// </summary>
        ThreadTraceSelectTotalTokens,
        /// <summary>
        /// 
        /// </summary>
        ThreadTraceSelectTraceID,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThreadsThreadTraceSelectFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThreadsThreadTraceSelectField value)
        {
            return value switch
            {
                ThreadsThreadTraceSelectField.ThreadTraceSelectCompletionCost => "COMPLETION_COST",
                ThreadsThreadTraceSelectField.ThreadTraceSelectCompletionCostDetails => "COMPLETION_COST_DETAILS",
                ThreadsThreadTraceSelectField.ThreadTraceSelectCompletionTokens => "COMPLETION_TOKENS",
                ThreadsThreadTraceSelectField.ThreadTraceSelectCompletionTokenDetails => "COMPLETION_TOKEN_DETAILS",
                ThreadsThreadTraceSelectField.ThreadTraceSelectEndTime => "END_TIME",
                ThreadsThreadTraceSelectField.ThreadTraceSelectErrorPreview => "ERROR_PREVIEW",
                ThreadsThreadTraceSelectField.ThreadTraceSelectFirstTokenTime => "FIRST_TOKEN_TIME",
                ThreadsThreadTraceSelectField.ThreadTraceSelectInputsPreview => "INPUTS_PREVIEW",
                ThreadsThreadTraceSelectField.ThreadTraceSelectLatency => "LATENCY",
                ThreadsThreadTraceSelectField.ThreadTraceSelectName => "NAME",
                ThreadsThreadTraceSelectField.ThreadTraceSelectOp => "OP",
                ThreadsThreadTraceSelectField.ThreadTraceSelectOutputsPreview => "OUTPUTS_PREVIEW",
                ThreadsThreadTraceSelectField.ThreadTraceSelectPromptCost => "PROMPT_COST",
                ThreadsThreadTraceSelectField.ThreadTraceSelectPromptCostDetails => "PROMPT_COST_DETAILS",
                ThreadsThreadTraceSelectField.ThreadTraceSelectPromptTokens => "PROMPT_TOKENS",
                ThreadsThreadTraceSelectField.ThreadTraceSelectPromptTokenDetails => "PROMPT_TOKEN_DETAILS",
                ThreadsThreadTraceSelectField.ThreadTraceSelectStartTime => "START_TIME",
                ThreadsThreadTraceSelectField.ThreadTraceSelectThreadID => "THREAD_ID",
                ThreadsThreadTraceSelectField.ThreadTraceSelectTotalCost => "TOTAL_COST",
                ThreadsThreadTraceSelectField.ThreadTraceSelectTotalTokens => "TOTAL_TOKENS",
                ThreadsThreadTraceSelectField.ThreadTraceSelectTraceID => "TRACE_ID",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThreadsThreadTraceSelectField? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETION_COST" => ThreadsThreadTraceSelectField.ThreadTraceSelectCompletionCost,
                "COMPLETION_COST_DETAILS" => ThreadsThreadTraceSelectField.ThreadTraceSelectCompletionCostDetails,
                "COMPLETION_TOKENS" => ThreadsThreadTraceSelectField.ThreadTraceSelectCompletionTokens,
                "COMPLETION_TOKEN_DETAILS" => ThreadsThreadTraceSelectField.ThreadTraceSelectCompletionTokenDetails,
                "END_TIME" => ThreadsThreadTraceSelectField.ThreadTraceSelectEndTime,
                "ERROR_PREVIEW" => ThreadsThreadTraceSelectField.ThreadTraceSelectErrorPreview,
                "FIRST_TOKEN_TIME" => ThreadsThreadTraceSelectField.ThreadTraceSelectFirstTokenTime,
                "INPUTS_PREVIEW" => ThreadsThreadTraceSelectField.ThreadTraceSelectInputsPreview,
                "LATENCY" => ThreadsThreadTraceSelectField.ThreadTraceSelectLatency,
                "NAME" => ThreadsThreadTraceSelectField.ThreadTraceSelectName,
                "OP" => ThreadsThreadTraceSelectField.ThreadTraceSelectOp,
                "OUTPUTS_PREVIEW" => ThreadsThreadTraceSelectField.ThreadTraceSelectOutputsPreview,
                "PROMPT_COST" => ThreadsThreadTraceSelectField.ThreadTraceSelectPromptCost,
                "PROMPT_COST_DETAILS" => ThreadsThreadTraceSelectField.ThreadTraceSelectPromptCostDetails,
                "PROMPT_TOKENS" => ThreadsThreadTraceSelectField.ThreadTraceSelectPromptTokens,
                "PROMPT_TOKEN_DETAILS" => ThreadsThreadTraceSelectField.ThreadTraceSelectPromptTokenDetails,
                "START_TIME" => ThreadsThreadTraceSelectField.ThreadTraceSelectStartTime,
                "THREAD_ID" => ThreadsThreadTraceSelectField.ThreadTraceSelectThreadID,
                "TOTAL_COST" => ThreadsThreadTraceSelectField.ThreadTraceSelectTotalCost,
                "TOTAL_TOKENS" => ThreadsThreadTraceSelectField.ThreadTraceSelectTotalTokens,
                "TRACE_ID" => ThreadsThreadTraceSelectField.ThreadTraceSelectTraceID,
                _ => null,
            };
        }
    }
}