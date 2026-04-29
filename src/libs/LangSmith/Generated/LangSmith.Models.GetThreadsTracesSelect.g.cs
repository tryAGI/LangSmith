
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetThreadsTracesSelect
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
        EndTime,
        /// <summary>
        /// 
        /// </summary>
        ErrorPreview,
        /// <summary>
        /// 
        /// </summary>
        FirstTokenTime,
        /// <summary>
        /// 
        /// </summary>
        InputsPreview,
        /// <summary>
        /// 
        /// </summary>
        Latency,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        Op,
        /// <summary>
        /// 
        /// </summary>
        OutputsPreview,
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
        StartTime,
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
    public static class GetThreadsTracesSelectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetThreadsTracesSelect value)
        {
            return value switch
            {
                GetThreadsTracesSelect.CompletionCost => "COMPLETION_COST",
                GetThreadsTracesSelect.CompletionCostDetails => "COMPLETION_COST_DETAILS",
                GetThreadsTracesSelect.CompletionTokens => "COMPLETION_TOKENS",
                GetThreadsTracesSelect.CompletionTokenDetails => "COMPLETION_TOKEN_DETAILS",
                GetThreadsTracesSelect.EndTime => "END_TIME",
                GetThreadsTracesSelect.ErrorPreview => "ERROR_PREVIEW",
                GetThreadsTracesSelect.FirstTokenTime => "FIRST_TOKEN_TIME",
                GetThreadsTracesSelect.InputsPreview => "INPUTS_PREVIEW",
                GetThreadsTracesSelect.Latency => "LATENCY",
                GetThreadsTracesSelect.Name => "NAME",
                GetThreadsTracesSelect.Op => "OP",
                GetThreadsTracesSelect.OutputsPreview => "OUTPUTS_PREVIEW",
                GetThreadsTracesSelect.PromptCost => "PROMPT_COST",
                GetThreadsTracesSelect.PromptCostDetails => "PROMPT_COST_DETAILS",
                GetThreadsTracesSelect.PromptTokens => "PROMPT_TOKENS",
                GetThreadsTracesSelect.PromptTokenDetails => "PROMPT_TOKEN_DETAILS",
                GetThreadsTracesSelect.StartTime => "START_TIME",
                GetThreadsTracesSelect.ThreadId => "THREAD_ID",
                GetThreadsTracesSelect.TotalCost => "TOTAL_COST",
                GetThreadsTracesSelect.TotalTokens => "TOTAL_TOKENS",
                GetThreadsTracesSelect.TraceId => "TRACE_ID",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetThreadsTracesSelect? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETION_COST" => GetThreadsTracesSelect.CompletionCost,
                "COMPLETION_COST_DETAILS" => GetThreadsTracesSelect.CompletionCostDetails,
                "COMPLETION_TOKENS" => GetThreadsTracesSelect.CompletionTokens,
                "COMPLETION_TOKEN_DETAILS" => GetThreadsTracesSelect.CompletionTokenDetails,
                "END_TIME" => GetThreadsTracesSelect.EndTime,
                "ERROR_PREVIEW" => GetThreadsTracesSelect.ErrorPreview,
                "FIRST_TOKEN_TIME" => GetThreadsTracesSelect.FirstTokenTime,
                "INPUTS_PREVIEW" => GetThreadsTracesSelect.InputsPreview,
                "LATENCY" => GetThreadsTracesSelect.Latency,
                "NAME" => GetThreadsTracesSelect.Name,
                "OP" => GetThreadsTracesSelect.Op,
                "OUTPUTS_PREVIEW" => GetThreadsTracesSelect.OutputsPreview,
                "PROMPT_COST" => GetThreadsTracesSelect.PromptCost,
                "PROMPT_COST_DETAILS" => GetThreadsTracesSelect.PromptCostDetails,
                "PROMPT_TOKENS" => GetThreadsTracesSelect.PromptTokens,
                "PROMPT_TOKEN_DETAILS" => GetThreadsTracesSelect.PromptTokenDetails,
                "START_TIME" => GetThreadsTracesSelect.StartTime,
                "THREAD_ID" => GetThreadsTracesSelect.ThreadId,
                "TOTAL_COST" => GetThreadsTracesSelect.TotalCost,
                "TOTAL_TOKENS" => GetThreadsTracesSelect.TotalTokens,
                "TRACE_ID" => GetThreadsTracesSelect.TraceId,
                _ => null,
            };
        }
    }
}